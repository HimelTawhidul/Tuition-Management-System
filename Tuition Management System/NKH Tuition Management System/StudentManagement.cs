using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using NKH_Tution.Function;

namespace NKH_Tution
{
    public partial class StudentManagement : Form
    {
        Functions fn = new Functions();
        DataGridView studentGrid = new DataGridView();

        public StudentManagement()
        {
            InitializeComponent();

            studentGrid.Dock = DockStyle.Fill;
            StudentShowPanel.Controls.Add(studentGrid);
            studentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentGrid.MultiSelect = false;
            studentGrid.ReadOnly = true;
            studentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentGrid.BackgroundColor = Color.White;
            studentGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            studentGrid.CellClick += studentGrid_CellClick;

            // Wire logout
            label14.Click += LogoutBtn_Click;

            LoadClasses();
            LoadSections();
            LoadStudents();
        }

        void LoadClasses()
        {
            try
            {
                DataTable dt = fn.GetData("SELECT ClassID, ClassName FROM ClassTbl ORDER BY ClassName");
                ClassBox.DataSource = dt;
                ClassBox.DisplayMember = "ClassName";
                ClassBox.ValueMember = "ClassID";
                ClassBox.SelectedIndex = -1;
            }
            catch { }
        }

        void LoadSections()
        {
            try
            {
                DataTable dt = fn.GetData("SELECT SectionID, SectionName FROM SectionTbl ORDER BY SectionName");
                SectionBox.DataSource = dt;
                SectionBox.DisplayMember = "SectionName";
                SectionBox.ValueMember = "SectionID";
                SectionBox.SelectedIndex = -1;
            }
            catch { }
        }

        void LoadStudents()
        {
            try
            {
                string query = @"
                    SELECT 
                        s.StudentID,
                        s.Name AS [Student Name],
                        c.ClassName AS [Class],
                        sec.SectionName AS [Section],
                        s.Phone,
                        CONVERT(VARCHAR,s.DateOfBirth,103) AS [Date of Birth],
                        s.Address,
                        ISNULL(p.TotalFees,0) AS [Total Fees],
                        ISNULL(p.Paid,0) AS [Paid],
                        ISNULL(p.TotalFees,0) - ISNULL(p.Paid,0) AS [Due],
                        ISNULL(att.AttPct,0) AS [Attendance %]
                    FROM StudentTbl s
                    LEFT JOIN ClassTbl c ON s.ClassID = c.ClassID
                    LEFT JOIN SectionTbl sec ON s.SectionID = sec.SectionID
                    LEFT JOIN (
                        SELECT StudentID, MAX(TotalFees) AS TotalFees, SUM(PayableAmount) AS Paid
                        FROM PaymentTbl GROUP BY StudentID
                    ) p ON s.StudentID = p.StudentID
                    LEFT JOIN (
                        SELECT ad.StudentID,
                            CAST(100.0*SUM(CASE WHEN ad.Status='Present' OR ad.Status='Late' THEN 1 ELSE 0 END)/COUNT(*) AS DECIMAL(5,1)) AS AttPct
                        FROM AttendenceDetailTbl ad
                        GROUP BY ad.StudentID
                    ) att ON s.StudentID = att.StudentID
                    ORDER BY s.StudentID";
                studentGrid.DataSource = fn.GetData(query);
            }
            catch (Exception ex)
            {
                try
                {
                    studentGrid.DataSource = fn.GetData("SELECT * FROM StudentTbl");
                }
                catch (Exception fallbackEx)
                {
                    MessageBox.Show(
                        $"Load failed.\nMain Error: {ex.Message}\nFallback Error: {fallbackEx.Message}",
                        "Critical Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // ===== NAVIGATION =====
        private void ClassForm_Click(object? sender, EventArgs e)
        {
            Class_Sec c = new Class_Sec();
            c.StartPosition = FormStartPosition.CenterScreen;
            c.FormClosed += (s, args) => this.Close();
            c.Show();
            this.Hide();
        }

        private void PaymentForm_Click(object? sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.StartPosition = FormStartPosition.CenterScreen;
            payment.FormClosed += (s, args) => this.Close();
            payment.Show();
            this.Hide();
        }

        private void AttendenceForm_Click(object? sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.StartPosition = FormStartPosition.CenterScreen;
            attendence.FormClosed += (s, args) => this.Close();
            attendence.Show();
            this.Hide();
        }

        private void UserForm_Click(object? sender, EventArgs e)
        {
            User user = new User();
            user.StartPosition = FormStartPosition.CenterScreen;
            user.FormClosed += (s, args) => this.Close();
            user.Show();
            this.Hide();
        }

        private void DashbordForm_Click(object? sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.StartPosition = FormStartPosition.CenterScreen;
            dashbord.FormClosed += (s, args) => this.Close();
            dashbord.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object? sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;

            login.FormClosed += (s, args) => Application.Exit(); // optional safety

            login.Show();
            this.Hide();
        }

        // ===== HOVER =====
        private void Control_MouseEnter(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.Red; }

        private void Control_MouseLeave(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.White; }

        // ===== ADD =====
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                ClassBox.SelectedValue == null ||
                SectionBox.SelectedValue == null ||
                string.IsNullOrWhiteSpace(PhoneBox.Text) ||
                string.IsNullOrWhiteSpace(AddressBox.Text))
            {
                MessageBox.Show("Please fill all required fields (Name, Phone, Address, Class, Section)!",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"INSERT INTO StudentTbl (Name, DateOfBirth, Phone, Address, ClassID, SectionID)
                                 VALUES (@Name, @DOB, @Phone, @Address, @Class, @Section)";
                SqlParameter[] param =
                {
                    new SqlParameter("@Name", NameBox.Text.Trim()),
                    new SqlParameter("@DOB", guna2DateTimePicker1.Value.Date),
                    new SqlParameter("@Phone", PhoneBox.Text.Trim()),
                    new SqlParameter("@Address", AddressBox.Text.Trim()),
                    new SqlParameter("@Class", Convert.ToInt32(ClassBox.SelectedValue)),
                    new SqlParameter("@Section", Convert.ToInt32(SectionBox.SelectedValue))
                };
                fn.ExecuteQuery(query, param);
                MessageBox.Show("Student Added Successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields(); LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== DELETE =====
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (studentGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(studentGrid.SelectedRows[0].Cells["StudentID"].Value);
                // Delete attendance details first
                fn.ExecuteQuery("DELETE FROM AttendenceDetailTbl WHERE StudentID=@id",
                    new[] { new SqlParameter("@id", id) });
                fn.ExecuteQuery("DELETE FROM PaymentTbl WHERE StudentID=@id",
                    new[] { new SqlParameter("@id", id) });
                fn.ExecuteQuery("DELETE FROM StudentTbl WHERE StudentID=@id",
                    new[] { new SqlParameter("@id", id) });
                MessageBox.Show("Student Deleted!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields(); LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== UPDATE =====
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (studentGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                ClassBox.SelectedValue == null || SectionBox.SelectedValue == null)
            {
                MessageBox.Show("Please fill all required fields!", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = Convert.ToInt32(studentGrid.SelectedRows[0].Cells["StudentID"].Value);
                string query = @"UPDATE StudentTbl SET
                    Name=@Name, DateOfBirth=@DOB, Phone=@Phone, Address=@Address,
                    ClassID=@Class, SectionID=@Section WHERE StudentID=@id";
                SqlParameter[] param =
                {
                    new SqlParameter("@Name", NameBox.Text.Trim()),
                    new SqlParameter("@DOB", guna2DateTimePicker1.Value.Date),
                    new SqlParameter("@Phone", PhoneBox.Text.Trim()),
                    new SqlParameter("@Address", AddressBox.Text.Trim()),
                    new SqlParameter("@Class", Convert.ToInt32(ClassBox.SelectedValue)),
                    new SqlParameter("@Section", Convert.ToInt32(SectionBox.SelectedValue)),
                    new SqlParameter("@id", id)
                };
                fn.ExecuteQuery(query, param);
                MessageBox.Show("Student Updated!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== SEARCH =====
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "SELECT s.StudentID, s.Name AS [Student Name], c.ClassName AS [Class], sec.SectionName AS [Section], s.Phone, s.Address FROM StudentTbl s LEFT JOIN ClassTbl c ON s.ClassID=c.ClassID LEFT JOIN SectionTbl sec ON s.SectionID=sec.SectionID WHERE s.Name LIKE @name";
                studentGrid.DataSource = fn.GetData(q,
                    new[] { new SqlParameter("@name", "%" + NameBox.Text + "%") });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== DOWNLOAD =====
        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if (studentGrid.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV File (*.csv)|*.csv";
            sfd.FileName = "Student_Details_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);

                    // Header
                    string[] headers = new string[studentGrid.Columns.Count];
                    for (int i = 0; i < studentGrid.Columns.Count; i++)
                        headers[i] = "\"" + studentGrid.Columns[i].HeaderText + "\"";
                    sw.WriteLine(string.Join(",", headers));

                    // Rows
                    foreach (DataGridViewRow row in studentGrid.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string[] cells = new string[studentGrid.Columns.Count];
                        for (int i = 0; i < studentGrid.Columns.Count; i++)
                            cells[i] = "\"" + (row.Cells[i].Value?.ToString() ?? "") + "\"";
                        sw.WriteLine(string.Join(",", cells));
                    }

                    MessageBox.Show("Data exported successfully to:\n" + sfd.FileName, "Export Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ===== GRID CLICK =====
        private void studentGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // 🔒 Prevent invalid row access (header click or no selection)
            if (e.RowIndex < 0 || studentGrid.SelectedRows.Count == 0)
                return;

            var row = studentGrid.SelectedRows[0];

            // =========================
            // 🟢 NAME (supports multiple column names)
            // =========================
            string? nameCol = studentGrid.Columns.Contains("Name") ? "Name" :
                              studentGrid.Columns.Contains("Student Name") ? "Student Name" : null;

            if (nameCol != null)
            {
                // Safe access using ?. and ?? (no null crash)
                NameBox.Text = row.Cells[nameCol]?.Value?.ToString() ?? "";
            }

            // =========================
            // 🟢 PHONE
            // =========================
            if (studentGrid.Columns.Contains("Phone"))
            {
                PhoneBox.Text = row.Cells["Phone"]?.Value?.ToString() ?? "";
            }

            // =========================
            // 🟢 ADDRESS
            // =========================
            if (studentGrid.Columns.Contains("Address"))
            {
                AddressBox.Text = row.Cells["Address"]?.Value?.ToString() ?? "";
            }

            // 🟢 CLASS (handle null + DBNull)

            if (studentGrid.Columns.Contains("ClassID"))
            {
                var classVal = row.Cells["ClassID"]?.Value;

                if (classVal != null && classVal != DBNull.Value)
                {
                    ClassBox.SelectedValue = classVal;
                }
            }

            // 🟢 SECTION (handle null + DBNull)
            if (studentGrid.Columns.Contains("SectionID"))
            {
                var sectionVal = row.Cells["SectionID"]?.Value;

                if (sectionVal != null && sectionVal != DBNull.Value)
                {
                    SectionBox.SelectedValue = sectionVal;
                }
            }
            // 🟢 DATE OF BIRTH (onak gulo column support korbe)

            string? dobCol = studentGrid.Columns.Contains("DateOfBirth") ? "DateOfBirth" :
                             studentGrid.Columns.Contains("Date of Birth") ? "Date of Birth" : null;

            if (dobCol != null)
            {
                var dobValue = row.Cells[dobCol]?.Value;

                // Ensure valid value before parsing
                if (dobValue != null && dobValue != DBNull.Value &&
                    DateTime.TryParse(dobValue.ToString(), out DateTime dob))
                {
                    guna2DateTimePicker1.Value = dob;
                }
            }
        }

        private void ClearFields()
        {
            NameBox.Text = ""; PhoneBox.Text = ""; AddressBox.Text = "";
            ClassBox.SelectedIndex = -1; SectionBox.SelectedIndex = -1;
            guna2DateTimePicker1.Value = DateTime.Now;
        }

        private void StudentShowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
