using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using NKH_Tution.Function;

namespace NKH_Tution
{
    public partial class User : Form
    {
        Functions fn = new Functions();
        DataGridView userGrid = new DataGridView();

        public User()
        {
            InitializeComponent();

            // Setup grid
            userGrid.Dock = DockStyle.Fill;
            userGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userGrid.MultiSelect = false;
            userGrid.ReadOnly = true;
            userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userGrid.BackgroundColor = Color.White;
            userGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            userGrid.CellClick += userGrid_CellClick;
            studentShowPanel.Controls.Add(userGrid);

            // Fix Role combobox items to match DB constraint
            comboBox4.Items.Clear();
            comboBox4.Items.Add("Admin");
            comboBox4.Items.Add("Teacher");
            comboBox4.SelectedIndex = -1;

            // Wire buttons
            button1.Click += AddBtn_Click;
            button2.Click += DeleteBtn_Click;
            button3.Click += UpdateBtn_Click;

            // Add Search button handler (button1 is Add, so wire search by label)
            label14.Click += LogoutBtn_Click;

            LoadUsers();
        }

        void LoadUsers()
        {
            try
            {
                string query = "SELECT UserID, Username, Role FROM UserTbl ORDER BY UserID";
                userGrid.DataSource = fn.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== ADD =====
        private void AddBtn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                comboBox4.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in Username, Password and Role.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check duplicate username
                DataTable chk = fn.GetData("SELECT COUNT(*) FROM UserTbl WHERE Username=@u",
                    new[] { new SqlParameter("@u", textBox1.Text.Trim()) });
                if (Convert.ToInt32(chk.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Username already exists!", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                fn.ExecuteQuery(
                    "INSERT INTO UserTbl (Username, Password, Role) VALUES (@u, @p, @r)",
                    new SqlParameter[] {
                        new("@u", textBox1.Text.Trim()),
                        new("@p", textBox2.Text.Trim()),
                        new("@r", comboBox4.Text)
                    });

                MessageBox.Show("User added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== UPDATE =====
        private void UpdateBtn_Click(object? sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                comboBox4.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(userGrid.SelectedRows[0].Cells["UserID"].Value);
                fn.ExecuteQuery(
                    "UPDATE UserTbl SET Username=@u, Password=@p, Role=@r WHERE UserID=@id",
                    new SqlParameter[] {
                        new("@u", textBox1.Text.Trim()),
                        new("@p", textBox2.Text.Trim()),
                        new("@r", comboBox4.Text),
                        new("@id", id)
                    });

                MessageBox.Show("User updated!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== DELETE =====
        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete this user?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(userGrid.SelectedRows[0].Cells["UserID"].Value);
                fn.ExecuteQuery("DELETE FROM UserTbl WHERE UserID=@id",
                    new[] { new SqlParameter("@id", id) });
                MessageBox.Show("User deleted!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== SEARCH =====
        private void SearchByUsername()
        {
            try
            {
                string q = "SELECT UserID, Username, Role FROM UserTbl WHERE Username LIKE @u ORDER BY UserID";
                userGrid.DataSource = fn.GetData(q,
                    new[] { new SqlParameter("@u", "%" + textBox1.Text.Trim() + "%") });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || userGrid.SelectedRows.Count == 0) return;
            var row = userGrid.SelectedRows[0];
            textBox1.Text = row.Cells["Username"].Value?.ToString() ?? "";
            textBox2.Text = ""; // Don't show password for security
            string role = row.Cells["Role"].Value?.ToString() ?? "";
            comboBox4.SelectedItem = role;
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox4.SelectedIndex = -1;
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

        private void DashbordForm_Click(object sender, EventArgs e)
        {
            Dashbord dashbord = new Dashbord();
            dashbord.StartPosition = FormStartPosition.CenterScreen;
            dashbord.FormClosed += (s, args) => this.Close();
            dashbord.Show();
            this.Hide();
            ;
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

        private void AttendenceForm_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.StartPosition = FormStartPosition.CenterScreen;
            attendence.FormClosed += (s, args) => this.Close();
            attendence.Show();
            this.Hide();
            ;
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.Red; }

        private void Control_MouseLeave(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.White; }
    }
}
