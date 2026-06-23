using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using NKH_Tution.Function;

namespace NKH_Tution
{
    public partial class Class_Sec : Form
    {
        Functions fn = new Functions();
        DataGridView classGrid = new DataGridView();

        public Class_Sec()
        {
            InitializeComponent();

            // Setup grid in ClassShowPanel
            classGrid.Dock = DockStyle.Fill;
            classGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            classGrid.MultiSelect = false;
            classGrid.ReadOnly = true;
            classGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            classGrid.BackgroundColor = Color.White;
            classGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            ClassShowPanel.Controls.Add(classGrid);

            // Rename Delete button label to AddSection label correctly 
            AddSectionBtn.Text = "Delete";
            AddSectionBtn.Click += DeleteBtn_Click;
            AddClassBtn.Click -= button1_Click;
            AddClassBtn.Click += AddBtn_Click;

            // Wire Logout
            label14.Click += LogoutBtn_Click;

            // Load sections into combo
            LoadSectionCombo();
            LoadClassData();
        }

        void LoadSectionCombo()
        {
            try
            {
                DataTable dt = fn.GetData("SELECT SectionID, SectionName FROM SectionTbl ORDER BY SectionName");
                SectionBox.DataSource = null;
                SectionBox.Items.Clear();
                SectionBox.DataSource = dt;
                SectionBox.DisplayMember = "SectionName";
                SectionBox.ValueMember = "SectionID";
                SectionBox.SelectedIndex = -1;
            }
            catch { }
        }

        void LoadClassData()
        {
            try
            {
                string query = @"
                    SELECT c.ClassID, c.ClassName, s.SectionName
                    FROM ClassTbl c
                    CROSS JOIN SectionTbl s
                    ORDER BY c.ClassID, s.SectionName";
                classGrid.DataSource = fn.GetData(query);
            }
            catch
            {
                try
                {
                    classGrid.DataSource = fn.GetData("SELECT * FROM ClassTbl");
                }
                catch { }
            }
        }

        private void AddBtn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) || SectionBox.SelectedValue == null)
            {
                MessageBox.Show("Please enter Class Name and select a Section.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if class already exists
                string checkQuery = "SELECT COUNT(*) FROM ClassTbl WHERE ClassName=@cn";
                DataTable check = fn.GetData(checkQuery,
                    new[] { new SqlParameter("@cn", NameBox.Text.Trim()) });

                if (Convert.ToInt32(check.Rows[0][0]) == 0)
                {
                    // Insert class
                    fn.ExecuteQuery("INSERT INTO ClassTbl (ClassName) VALUES (@cn)",
                        new[] { new SqlParameter("@cn", NameBox.Text.Trim()) });
                    MessageBox.Show("Class '" + NameBox.Text.Trim() + "' added successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Class '" + NameBox.Text.Trim() + "' already exists.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                NameBox.Text = "";
                SectionBox.SelectedIndex = -1;
                LoadClassData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding class: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            if (classGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Delete this class? Students assigned to it will be affected.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                int classId = Convert.ToInt32(classGrid.SelectedRows[0].Cells["ClassID"].Value);

                // Check if students are using this class
                DataTable dt = fn.GetData("SELECT COUNT(*) FROM StudentTbl WHERE ClassID=@id",
                    new[] { new SqlParameter("@id", classId) });
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Cannot delete: students are assigned to this class.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                fn.ExecuteQuery("DELETE FROM ClassTbl WHERE ClassID=@id",
                    new[] { new SqlParameter("@id", classId) });
                MessageBox.Show("Class deleted!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClassData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: " + ex.Message, "Error",
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
        private void StudentForm_Click(object sender, EventArgs e)
        {
            StudentManagement student = new StudentManagement();
            student.StartPosition = FormStartPosition.CenterScreen;
            student.FormClosed += (s, args) => this.Close();
            student.Show();
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

        private void AttendenceForm_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.StartPosition = FormStartPosition.CenterScreen;
            attendence.FormClosed += (s, args) => this.Close();
            attendence.Show();
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
            Dashbord dashbord = new Dashbord();
            dashbord.StartPosition = FormStartPosition.CenterScreen;
            dashbord.FormClosed += (s, args) => this.Close();
            dashbord.Show();
            this.Hide();

        }

        private void button1_Click(object? sender, EventArgs e) { }

        private void Control_MouseEnter(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.Red; }

        private void Control_MouseLeave(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.White; }
    }
}
