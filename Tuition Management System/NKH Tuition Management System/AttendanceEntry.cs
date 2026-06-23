using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using NKH_Tution.Function;

namespace NKH_Tution
{
    /// <summary>
    /// Per-student attendance entry form opened from the Attendence form.
    /// Shows all students in the selected class/section and lets the user mark Present/Absent/Late.
    /// </summary>
    public class AttendanceEntry : Form
    {
        Functions fn;
        int sessionId, classId, sectionId;
        DateTime attDate;
        DataGridView grid = new DataGridView();
        Button saveBtn = new Button();
        Button exportBtn = new Button();
        Label titleLabel = new Label();
        Label infoLabel = new Label();

        public AttendanceEntry(int sessionId, int classId, int sectionId, DateTime date, Functions fn)
        {
            this.sessionId = sessionId;
            this.classId = classId;
            this.sectionId = sectionId;
            this.attDate = date;
            this.fn = fn;

            BuildUI();
            LoadStudents();
        }

        void BuildUI()
        {
            this.Text = "Attendance Entry";
            this.Size = new Size(800, 600);
            this.BackColor = Color.MidnightBlue;

            titleLabel.Text = "ATTENDANCE ENTRY";
            titleLabel.Font = new Font("Elephant", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Height = 50;

            infoLabel.Font = new Font("Segoe UI", 10F);
            infoLabel.ForeColor = Color.LightGray;
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            infoLabel.Dock = DockStyle.Top;
            infoLabel.Height = 30;
            infoLabel.Text = $"Date: {attDate:dd/MM/yyyy}  |  Session ID: {sessionId}";

            grid.Dock = DockStyle.Fill;
            grid.BackgroundColor = Color.White;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AllowUserToAddRows = false;

            Panel btnPanel = new Panel();
            btnPanel.Dock = DockStyle.Bottom;
            btnPanel.Height = 60;
            btnPanel.BackColor = Color.DarkBlue;

            saveBtn.Text = "Save Attendance";
            saveBtn.Font = new Font("Elephant", 11F);
            saveBtn.BackColor = Color.DarkGreen;
            saveBtn.ForeColor = Color.White;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.Size = new Size(200, 40);
            saveBtn.Location = new Point(200, 10);
            saveBtn.Click += SaveBtn_Click;

            exportBtn.Text = "Export to CSV";
            exportBtn.Font = new Font("Elephant", 11F);
            exportBtn.BackColor = Color.DarkRed;
            exportBtn.ForeColor = Color.White;
            exportBtn.FlatStyle = FlatStyle.Flat;
            exportBtn.FlatAppearance.BorderSize = 0;
            exportBtn.Size = new Size(200, 40);
            exportBtn.Location = new Point(420, 10);
            exportBtn.Click += ExportBtn_Click;

            btnPanel.Controls.Add(saveBtn);
            btnPanel.Controls.Add(exportBtn);

            this.Controls.Add(grid);
            this.Controls.Add(btnPanel);
            this.Controls.Add(infoLabel);
            this.Controls.Add(titleLabel);
        }

        void LoadStudents()
        {
            try
            {
                // Get all students in class/section
                DataTable students = fn.GetData(
                    @"SELECT s.StudentID, s.Name AS [Student Name]
                      FROM StudentTbl s
                      WHERE s.ClassID=@cid AND s.SectionID=@sid
                      ORDER BY s.Name",
                    new SqlParameter[] {
                        new("@cid", classId),
                        new("@sid", sectionId)
                    });

                // Get existing attendance for this session
                DataTable existing = fn.GetData(
                    "SELECT StudentID, Status FROM AttendenceDetailTbl WHERE SessionID=@sess",
                    new[] { new SqlParameter("@sess", sessionId) });

                // Build editable table
                DataTable dt = new DataTable();
                dt.Columns.Add("StudentID", typeof(int));
                dt.Columns.Add("Student Name", typeof(string));
                dt.Columns.Add("Status", typeof(string));

                foreach (DataRow sr in students.Rows)
                {
                    string status = "Present";
                    // Check if already recorded
                    foreach (DataRow er in existing.Rows)
                    {
                        if (Convert.ToInt32(er["StudentID"]) == Convert.ToInt32(sr["StudentID"]))
                        {
                            status = er["Status"].ToString();
                            break;
                        }
                    }
                    dt.Rows.Add(sr["StudentID"], sr["Student Name"], status);
                }

                grid.DataSource = dt;

                // Make Status column a combobox
                if (grid.Columns.Contains("Status"))
                {
                    grid.Columns["Status"].ReadOnly = false;
                    DataGridViewComboBoxColumn statusCol = new DataGridViewComboBoxColumn();
                    statusCol.Name = "StatusCombo";
                    statusCol.HeaderText = "Status";
                    statusCol.DataSource = new string[] { "Present", "Absent", "Late" };
                    statusCol.DataPropertyName = "Status";
                    statusCol.Width = 150;
                    grid.Columns.Remove("Status");
                    grid.Columns.Add(statusCol);
                }

                if (grid.Columns.Contains("StudentID"))
                    grid.Columns["StudentID"].ReadOnly = true;
                if (grid.Columns.Contains("Student Name"))
                    grid.Columns["Student Name"].ReadOnly = true;

                infoLabel.Text += $"  |  Total Students: {students.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;

                    int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                    string status = row.Cells["StatusCombo"].Value?.ToString() ?? "Present";

                    // Upsert: check if record exists
                    DataTable exists = fn.GetData(
                        "SELECT AttendanceID FROM AttendenceDetailTbl WHERE SessionID=@s AND StudentID=@st",
                        new SqlParameter[] {
                            new("@s", sessionId),
                            new("@st", studentId)
                        });

                    if (exists.Rows.Count > 0)
                    {
                        fn.ExecuteQuery(
                            "UPDATE AttendenceDetailTbl SET Status=@status WHERE SessionID=@s AND StudentID=@st",
                            new SqlParameter[] {
                                new("@status", status),
                                new("@s", sessionId),
                                new("@st", studentId)
                            });
                    }
                    else
                    {
                        fn.ExecuteQuery(
                            "INSERT INTO AttendenceDetailTbl (SessionID, StudentID, Status) VALUES (@s, @st, @status)",
                            new SqlParameter[] {
                                new("@s", sessionId),
                                new("@st", studentId),
                                new("@status", status)
                            });
                    }
                }

                MessageBox.Show("Attendance saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving attendance: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // AttendanceEntry
            // 
            ClientSize = new Size(649, 487);
            Name = "AttendanceEntry";
            ResumeLayout(false);

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = $"Attendance_{attDate:yyyyMMdd}_Session{sessionId}";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine("\"StudentID\",\"Student Name\",\"Status\",\"Date\"");
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        if (row.IsNewRow) continue;
                        sw.WriteLine($"\"{row.Cells["StudentID"].Value}\"," +
                                     $"\"{row.Cells["Student Name"].Value}\"," +
                                     $"\"{row.Cells["StatusCombo"].Value}\"," +
                                     $"\"{attDate:dd/MM/yyyy}\"");
                    }
                    MessageBox.Show("Exported to:\n" + sfd.FileName, "Export Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
