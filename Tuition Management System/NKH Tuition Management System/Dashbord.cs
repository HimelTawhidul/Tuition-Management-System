using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NKH_Tution.Function;

namespace NKH_Tution
{
    public partial class Dashbord : Form
    {
        Functions fn = new Functions();

        public Dashbord()
        {
            InitializeComponent();
            this.Load += Form_Load;
            LogoutBtn.Click += LogoutBtn_Click;      // logout
        }

        private void Form_Load(object? sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                DataTable dtStudents = fn.GetData("SELECT COUNT(*) AS Total FROM StudentTbl");
                ShowTotalStudent.Text = dtStudents.Rows.Count > 0 ? dtStudents.Rows[0]["Total"].ToString() : "0";

                DataTable dtUsers = fn.GetData("SELECT COUNT(*) AS Total FROM UserTbl");
                ShowTotalTeacher.Text = dtUsers.Rows.Count > 0 ? dtUsers.Rows[0]["Total"].ToString() : "0";

                DataTable dtDue = fn.GetData("SELECT ISNULL(SUM(TotalFees - PayableAmount),0) AS TotalDue FROM PaymentTbl");
                decimal due = dtDue.Rows.Count > 0 ? Convert.ToDecimal(dtDue.Rows[0]["TotalDue"]) : 0;
                ShowTotalDue.Text = "BDT " + due.ToString("N0");

                DataTable dtIncome = fn.GetData("SELECT ISNULL(SUM(PayableAmount),0) AS Income FROM PaymentTbl");
                decimal income = dtIncome.Rows.Count > 0 ? Convert.ToDecimal(dtIncome.Rows[0]["Income"]) : 0;
                ShowTotalIncome.Text = "BDT " + income.ToString("N0");
            }
            catch
            {
                ShowTotalStudent.Text = "0";
                ShowTotalTeacher.Text = "0";
                ShowTotalDue.Text = "BDT 0";
                ShowTotalIncome.Text = "BDT 0";
            }
        }

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

        private void LogoutBtn_Click(object? sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;

            login.FormClosed += (s, args) => Application.Exit(); // optional safety

            login.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void ShowTotalStudent_Paint(object sender, PaintEventArgs e) { }
        private void ShowTotalTeacher_Paint(object sender, PaintEventArgs e) { }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Control c) c.ForeColor = Color.Red;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Control c) c.ForeColor = Color.White;
        }
    }
}
