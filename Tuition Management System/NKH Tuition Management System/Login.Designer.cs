namespace NKH_Tution
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            LoginBtn = new Button();
            label_footer = new Label();
            lblPass = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 625);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(UsernameBox);
            panel2.Controls.Add(PasswordBox);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(label_footer);
            panel2.Controls.Add(lblPass);
            panel2.Location = new Point(400, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 625);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Elephant", 22F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(125, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 69);
            label2.TabIndex = 0;
            label2.Text = "LOGIN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(100, 181);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 31);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = Color.FromArgb(30, 30, 80);
            UsernameBox.BorderStyle = BorderStyle.FixedSingle;
            UsernameBox.Font = new Font("Segoe UI", 11F);
            UsernameBox.ForeColor = Color.White;
            UsernameBox.Location = new Point(100, 215);
            UsernameBox.Margin = new Padding(4);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(400, 37);
            UsernameBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(30, 30, 80);
            PasswordBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordBox.Font = new Font("Segoe UI", 11F);
            PasswordBox.ForeColor = Color.White;
            PasswordBox.Location = new Point(100, 321);
            PasswordBox.Margin = new Padding(4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '●';
            PasswordBox.Size = new Size(400, 37);
            PasswordBox.TabIndex = 3;
            PasswordBox.KeyDown += PasswordBox_KeyDown;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.DarkRed;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Elephant", 13F, FontStyle.Bold);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(100, 406);
            LoginBtn.Margin = new Padding(4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(400, 62);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label_footer
            // 
            label_footer.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label_footer.ForeColor = Color.Gray;
            label_footer.Location = new Point(100, 538);
            label_footer.Margin = new Padding(4, 0, 4, 0);
            label_footer.Name = "label_footer";
            label_footer.Size = new Size(400, 31);
            label_footer.TabIndex = 5;
            label_footer.Text = "© NKH Tution Management";
            label_footer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            lblPass.Font = new Font("Segoe UI", 10F);
            lblPass.ForeColor = Color.LightGray;
            lblPass.Location = new Point(100, 288);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(138, 31);
            lblPass.TabIndex = 6;
            lblPass.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1000, 625);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NKH Tution - Login";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button LoginBtn;
        private Label label_footer;
        private Label lblPass;
        private PictureBox pictureBox1;
    }
}
