using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using NKH_Tution.Function;

namespace NKH_Tution
{
    public partial class Attendence : Form
    {
        Functions fn = new Functions();
        DataGridView attGrid = new DataGridView();

        public Attendence()
        {
            InitializeComponent();

            // Setup summary grid in ShowAttendencePanel
            attGrid.Dock = DockStyle.Fill;
            attGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            attGrid.MultiSelect = false;
            attGrid.ReadOnly = true;
            attGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attGrid.BackgroundColor = Color.White;
            attGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            ShowAttendencePanel.Controls.Add(attGrid);

            // Rename / relabel combo boxes from DB
            label3.Text = "Class";
            label18.Text = "Section";

            // Wire buttons
            EnterBtn.Click += EnterBtn_Click;
            label14.Click += LogoutBtn_Click;

            LoadClassCombo();
            LoadSectionCombo();
            LoadAttendanceSummary();
        }

        void LoadClassCombo()
        {
            try
            {
                DataTable dt = fn.GetData("SELECT ClassID, ClassName FROM ClassTbl ORDER BY ClassName");
                showAttendenceBox.DataSource = null;
                showAttendenceBox.Items.Clear();
                showAttendenceBox.DataSource = dt;
                showAttendenceBox.DisplayMember = "ClassName";
                showAttendenceBox.ValueMember = "ClassID";
                showAttendenceBox.SelectedIndex = -1;
            }
            catch { }
        }

        void LoadSectionCombo()
        {
            try
            {
                DataTable dt = fn.GetData("SELECT SectionID, SectionName FROM SectionTbl ORDER BY SectionName");
                comboBox4.DataSource = null;
                comboBox4.Items.Clear();
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "SectionName";
                comboBox4.ValueMember = "SectionID";
                comboBox4.SelectedIndex = -1;
            }
            catch { }
        }

        void LoadAttendanceSummary()
        {
            try
            {
                string query = @"
                    SELECT
                        a.SessionID,
                        CONVERT(VARCHAR, a.Date, 103) AS [Date],
                        c.ClassName AS [Class],
                        s.SectionName AS [Section],
                        COUNT(ad.AttendanceID) AS [Total Students],
                        SUM(CASE WHEN ad.Status='Present' THEN 1 ELSE 0 END) AS [Present],
                        SUM(CASE WHEN ad.Status='Absent' THEN 1 ELSE 0 END) AS [Absent],
                        SUM(CASE WHEN ad.Status='Late' THEN 1 ELSE 0 END) AS [Late]
                    FROM AttendenceTbl a
                    INNER JOIN ClassTbl c ON a.ClassID = c.ClassID
                    INNER JOIN SectionTbl s ON a.SectionID = s.SectionID
                    LEFT JOIN AttendenceDetailTbl ad ON a.SessionID = ad.SessionID
                    GROUP BY a.SessionID, a.Date, c.ClassName, s.SectionName
                    ORDER BY a.Date DESC";
                attGrid.DataSource = fn.GetData(query);

                // Add Details button column if not present
                if (!attGrid.Columns.Contains("Details"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                    btnCol.Name = "Details";
                    btnCol.HeaderText = "Details (Excel)";
                    btnCol.Text = "Export";
                    btnCol.UseColumnTextForButtonValue = true;
                    attGrid.Columns.Add(btnCol);
                    attGrid.CellClick += AttGrid_CellClick;
                }
            }
            catch
            {
                try { attGrid.DataSource = fn.GetData("SELECT * FROM AttendenceTbl"); }
                catch { }
            }
        }

        private void AttGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.RowIndex >= attGrid.Rows.Count)
                return;

            if (!attGrid.Columns.Contains("SessionID"))
                return;

            var cellValue = attGrid.Rows[e.RowIndex].Cells["SessionID"].Value;

            if (cellValue == null || cellValue == DBNull.Value)
                return;

            if (attGrid.Columns[e.ColumnIndex].Name == "Details")
            {
                int sessionId = Convert.ToInt32(cellValue);
                ExportSessionToExcel(sessionId);
            }
        }

        private void ExportSessionToExcel(int sessionId)
        {
            try
            {
                string query = @"
                    SELECT s.StudentID, s.Name AS [Student Name],
                           c.ClassName AS [Class], sec.SectionName AS [Section],
                           ad.Status AS [Attendance Status],
                           CONVERT(VARCHAR, a.Date, 103) AS [Date]
                    FROM AttendenceDetailTbl ad
                    INNER JOIN StudentTbl s ON ad.StudentID = s.StudentID
                    INNER JOIN AttendenceTbl a ON ad.SessionID = a.SessionID
                    INNER JOIN ClassTbl c ON a.ClassID = c.ClassID
                    INNER JOIN SectionTbl sec ON a.SectionID = sec.SectionID
                    WHERE ad.SessionID = @sid
                    ORDER BY s.Name";

                DataTable dt = fn.GetData(query, new[] { new SqlParameter("@sid", sessionId) });

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.FileName = "Attendance_Session_" + sessionId + "_" + DateTime.Now.ToString("yyyyMMdd");

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using StreamWriter sw = new StreamWriter(sfd.FileName);
                    // Header
                    string[] headers = new string[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                        headers[i] = "\"" + dt.Columns[i].ColumnName + "\"";
                    sw.WriteLine(string.Join(",", headers));

                    // Data
                    foreach (DataRow row in dt.Rows)
                    {
                        string[] vals = new string[dt.Columns.Count];
                        for (int i = 0; i < dt.Columns.Count; i++)
                            vals[i] = "\"" + (row[i]?.ToString() ?? "") + "\"";
                        sw.WriteLine(string.Join(",", vals));
                    }

                    MessageBox.Show("Attendance exported to:\n" + sfd.FileName,
                        "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnterBtn_Click(object? sender, EventArgs e)
        {
            if (showAttendenceBox.SelectedValue == null || comboBox4.SelectedValue == null)
            {
                MessageBox.Show("Please select Class and Section.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int classId = Convert.ToInt32(showAttendenceBox.SelectedValue);
            int sectionId = Convert.ToInt32(comboBox4.SelectedValue);
            DateTime attDate = guna2DateTimePicker1.Value.Date;

            try
            {
                // Check if session already exists
                DataTable chk = fn.GetData(
                    "SELECT SessionID FROM AttendenceTbl WHERE ClassID=@cid AND SectionID=@sid AND Date=@d",
                    new SqlParameter[] {
                        new("@cid", classId),
                        new("@sid", sectionId),
                        new("@d", attDate)
                    });

                int sessionId;
                if (chk.Rows.Count > 0)
                {
                    sessionId = Convert.ToInt32(chk.Rows[0]["SessionID"]);
                    MessageBox.Show("Attendance session for this class/section/date already exists. Opening for editing.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Create new session
                    fn.ExecuteQuery(
                        "INSERT INTO AttendenceTbl (ClassID, SectionID, Date) VALUES (@cid, @sid, @d)",
                        new SqlParameter[] {
                            new("@cid", classId),
                            new("@sid", sectionId),
                            new("@d", attDate)
                        });

                    DataTable newSess = fn.GetData(
                        "SELECT TOP 1 SessionID FROM AttendenceTbl WHERE ClassID=@cid AND SectionID=@sid AND Date=@d",
                        new SqlParameter[] {
                            new("@cid", classId),
                            new("@sid", sectionId),
                            new("@d", attDate)
                        });
                    sessionId = Convert.ToInt32(newSess.Rows[0]["SessionID"]);
                }

                // Open per-student attendance entry form
                AttendanceEntry entryForm = new AttendanceEntry(sessionId, classId, sectionId, attDate, fn);
                entryForm.StartPosition = FormStartPosition.CenterScreen;
                entryForm.ShowDialog();

                LoadAttendanceSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogoutBtn_Click(object? sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;

            login.FormClosed += (s, args) => Application.Exit(); // optional safety

            login.Show();
            this.Hide();
        }

        // ===== NAVIGATION =====
        private void label14_Click(object sender, EventArgs e) { }

        private void StudentForm_Click(object sender, EventArgs e)
        {
            StudentManagement student = new StudentManagement();
            student.StartPosition = FormStartPosition.CenterScreen;
            student.FormClosed += (s, args) => this.Close();
            student.Show();
            this.Hide();
        }

        private void ClassForm_Click(object sender, EventArgs e)
        {
            Class_Sec c = new Class_Sec();
            c.StartPosition = FormStartPosition.CenterScreen;
            c.FormClosed += (s, args) => this.Close();
            c.Show();
            this.Hide();
        }

        private void PaymentForm_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.StartPosition = FormStartPosition.CenterScreen;
            payment.FormClosed += (s, args) => this.Close();
            payment.Show();
            this.Hide();
        }

        private void UserForm_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.StartPosition = FormStartPosition.CenterScreen;
            user.FormClosed += (s, args) => this.Close();
            user.Show();
            this.Hide();
        }

        private void DashbordForm_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.StartPosition = FormStartPosition.CenterScreen;
            user.FormClosed += (s, args) => this.Close();
            user.Show();
            this.Hide();
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.Red; }

        private void Control_MouseLeave(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.White; }
    }
}
