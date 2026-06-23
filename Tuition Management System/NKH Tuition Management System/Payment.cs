using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using NKH_Tution.Function;

namespace NKH_Tution
{
    public partial class Payment : Form
    {
        Functions fn = new Functions();
        DataGridView payGrid = new DataGridView();

        public Payment()
        {
            InitializeComponent();

            // Setup grid
            payGrid.Dock = DockStyle.Fill;
            payGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            payGrid.MultiSelect = false;
            payGrid.ReadOnly = true;
            payGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            payGrid.BackgroundColor = Color.White;
            payGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            ShowPaymentHistoryPanel.Controls.Add(payGrid);

            // Wire buttons
            PaymentBtn.Click += PaymentBtn_Click;
            SearchBtn.Click += SearchBtn_Click;
            label14.Click += LogoutBtn_Click;

            LoadPaymentHistory();
        }

        void LoadPaymentHistory()
        {
            try
            {
                string query = @"
                    SELECT 
                        p.PaymentID,
                        p.StudentID,
                        s.Name AS [Student Name],
                        CONVERT(VARCHAR, p.PaymentDate, 103) AS [Payment Date],
                        p.TotalFees AS [Total Fees],
                        p.PayableAmount AS [Payable Amount],
                        (p.TotalFees - p.PayableAmount) AS [Due Amount],
                        p.PaymentType AS [Payment Type]
                    FROM PaymentTbl p
                    INNER JOIN StudentTbl s ON p.StudentID = s.StudentID
                    ORDER BY p.PaymentDate DESC";
                payGrid.DataSource = fn.GetData(query);
            }
            catch
            {
                try { payGrid.DataSource = fn.GetData("SELECT * FROM PaymentTbl"); }
                catch { }
            }
        }

        private void PaymentBtn_Click(object? sender, EventArgs e)
        {
            // Validate all fields
            if (string.IsNullOrWhiteSpace(StudentIdBox.Text) ||
                string.IsNullOrWhiteSpace(TotalFeeBox.Text) ||
                string.IsNullOrWhiteSpace(PayableAmountBox.Text) ||
                PaymentOptionBox.SelectedIndex < 0)
            {
                MessageBox.Show("Missing Data", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(StudentIdBox.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Invalid Student ID. Please enter a numeric ID.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(TotalFeeBox.Text.Trim(), out decimal totalFees) || totalFees <= 0)
            {
                MessageBox.Show("Invalid Total Fees amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(PayableAmountBox.Text.Trim(), out decimal payable) || payable <= 0)
            {
                MessageBox.Show("Invalid Payable Amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (payable > totalFees)
            {
                MessageBox.Show("Payable Amount cannot exceed Total Fees.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check student exists
                DataTable chk = fn.GetData("SELECT COUNT(*) FROM StudentTbl WHERE StudentID=@id",
                    new[] { new SqlParameter("@id", studentId) });
                if (Convert.ToInt32(chk.Rows[0][0]) == 0)
                {
                    MessageBox.Show("Student ID not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"INSERT INTO PaymentTbl (StudentID, PaymentDate, TotalFees, PayableAmount, PaymentType)
                                 VALUES (@sid, @date, @total, @payable, @type)";
                string paymentType = PaymentOptionBox.Text;

                if (string.IsNullOrWhiteSpace(paymentType))
                {
                    MessageBox.Show("Please select a payment type",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlParameter[] param =
                {
                       new SqlParameter("@sid", studentId),
                       new SqlParameter("@date", guna2DateTimePicker1.Value.Date),
                       new SqlParameter("@total", totalFees),
                       new SqlParameter("@payable", payable),
                       new SqlParameter("@type", paymentType)
                };

                fn.ExecuteQuery(query, param);
                MessageBox.Show("Payment recorded successfully!\n" +
                    $"Student ID: {studentId}\nTotal Fees: {totalFees:N2}\n" +
                    $"Paid: {payable:N2}\nDue: {(totalFees - payable):N2}",
                    "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearPaymentFields();
                LoadPaymentHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording payment: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StudentIdBox.Text))
            {
                LoadPaymentHistory();
                return;
            }

            if (!int.TryParse(StudentIdBox.Text.Trim(), out int sid))
            {
                MessageBox.Show("Please enter a valid numeric Student ID.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Load student info
                string sQuery = "SELECT StudentID, Name, Phone FROM StudentTbl WHERE StudentID=@id";
                DataTable sdt = fn.GetData(sQuery, new[] { new SqlParameter("@id", sid) });

                if (sdt.Rows.Count > 0)
                {
                    // Also pre-fill latest TotalFees if available
                    DataTable feedt = fn.GetData(
                        "SELECT TOP 1 TotalFees FROM PaymentTbl WHERE StudentID=@id ORDER BY PaymentDate DESC",
                        new[] { new SqlParameter("@id", sid) });
                    if (feedt.Rows.Count > 0)
                        TotalFeeBox.Text = feedt.Rows[0]["TotalFees"].ToString();
                }
                else
                {
                    MessageBox.Show("Student not found.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Filter payment history
                string query = @"
                    SELECT p.PaymentID, p.StudentID, s.Name AS [Student Name],
                           CONVERT(VARCHAR,p.PaymentDate,103) AS [Payment Date],
                           p.TotalFees AS [Total Fees], p.PayableAmount AS [Payable Amount],
                           (p.TotalFees - p.PayableAmount) AS [Due Amount],
                           p.PaymentType AS [Payment Type]
                    FROM PaymentTbl p INNER JOIN StudentTbl s ON p.StudentID=s.StudentID
                    WHERE p.StudentID=@id ORDER BY p.PaymentDate DESC";
                payGrid.DataSource = fn.GetData(query, new[] { new SqlParameter("@id", sid) });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearPaymentFields()
        {
            StudentIdBox.Text = "";
            TotalFeeBox.Text = "";
            PayableAmountBox.Text = "";
            PaymentOptionBox.SelectedIndex = -1;
            guna2DateTimePicker1.Value = DateTime.Now;
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

        }


        private void ClassForm_Click(object sender, EventArgs e)
        {
            Class_Sec c = new Class_Sec();
            c.StartPosition = FormStartPosition.CenterScreen;
            c.FormClosed += (s, args) => this.Close();
            c.Show();
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

        private void Control_MouseEnter(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.Red; }

        private void Control_MouseLeave(object sender, EventArgs e)
        { if (sender is Control c) c.ForeColor = Color.White; }
    }
}
