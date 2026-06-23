using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using NKH_Tution.Function;

namespace NKH_Tution
{
    public partial class Login : Form
    {
        Functions fn = new Functions();

        public Login()
        {
            InitializeComponent();
            this.AcceptButton = LoginBtn;  //Enter Press Korleo Kaz korbe
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            //Null Check Kore
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Username and Password.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Database Check Kore
            try
            {
                string query = "SELECT COUNT(*) FROM UserTbl WHERE Username=@u AND Password=@p";
                SqlParameter[] param =
                {
                    new SqlParameter("@u", username),
                    new SqlParameter("@p", password)
                };

                DataTable dt = fn.GetData(query, param);
                int count = Convert.ToInt32(dt.Rows[0][0]);

                if (count > 0)
                {
                    Dashbord dash = new Dashbord();
                    dash.StartPosition = FormStartPosition.CenterScreen;
                    dash.Show();
                    this.Hide();
                    dash.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordBox.Clear();
                    UsernameBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoginBtn_Click(sender, e);
        }
    }
}
