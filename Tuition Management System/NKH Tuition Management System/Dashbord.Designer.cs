namespace NKH_Tution
{
    partial class Dashbord
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            panel2 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            LogoutBtn = new Label();
            PaymentForm = new Label();
            UserForm = new Label();
            AttendenceForm = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ClassForm = new Label();
            panel3 = new Panel();
            StudentForm = new Label();
            label15 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            TStudent = new Panel();
            label2 = new Label();
            ShowTotalStudent = new Label();
            ShowTotalTeacher = new Label();
            NetIncome = new Panel();
            label4 = new Label();
            ShowTotalIncome = new Label();
            TDue = new Panel();
            label5 = new Label();
            ShowTotalDue = new Label();
            TUser = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            TStudent.SuspendLayout();
            NetIncome.SuspendLayout();
            TDue.SuspendLayout();
            TUser.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Location = new Point(220, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1564, 813);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCoral;
            panel5.Location = new Point(75, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(223, 141);
            panel5.TabIndex = 75;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(876, 112);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 62;
            label1.Text = "DASHBORD";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(47, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 891);
            panel1.TabIndex = 60;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(LogoutBtn);
            panel4.Location = new Point(0, 733);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 58);
            panel4.TabIndex = 17;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.None;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(50, 10);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(125, 33);
            LogoutBtn.TabIndex = 18;
            LogoutBtn.Text = "Logout";
            LogoutBtn.TextAlign = ContentAlignment.MiddleCenter;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // PaymentForm
            // 
            PaymentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentForm.ForeColor = SystemColors.ControlLightLight;
            PaymentForm.Location = new Point(63, 318);
            PaymentForm.Name = "PaymentForm";
            PaymentForm.Size = new Size(160, 28);
            PaymentForm.TabIndex = 20;
            PaymentForm.Text = "Payment";
            PaymentForm.Click += PaymentForm_Click;
            PaymentForm.MouseEnter += Control_MouseEnter;
            PaymentForm.MouseLeave += Control_MouseLeave;
            // 
            // UserForm
            // 
            UserForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserForm.ForeColor = SystemColors.ControlLightLight;
            UserForm.Location = new Point(63, 421);
            UserForm.Name = "UserForm";
            UserForm.Size = new Size(157, 28);
            UserForm.TabIndex = 21;
            UserForm.Text = "User";
            UserForm.Click += UserForm_Click;
            UserForm.MouseEnter += Control_MouseEnter;
            UserForm.MouseLeave += Control_MouseLeave;
            // 
            // AttendenceForm
            // 
            AttendenceForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttendenceForm.ForeColor = SystemColors.ControlLightLight;
            AttendenceForm.Location = new Point(63, 368);
            AttendenceForm.Name = "AttendenceForm";
            AttendenceForm.Size = new Size(160, 28);
            AttendenceForm.TabIndex = 19;
            AttendenceForm.Text = "Attendence";
            AttendenceForm.Click += AttendenceForm_Click;
            AttendenceForm.MouseEnter += Control_MouseEnter;
            AttendenceForm.MouseLeave += Control_MouseLeave;
            // 
            // ClassForm
            // 
            ClassForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassForm.ForeColor = SystemColors.ControlLightLight;
            ClassForm.Location = new Point(63, 268);
            ClassForm.Name = "ClassForm";
            ClassForm.Size = new Size(160, 28);
            ClassForm.TabIndex = 18;
            ClassForm.Text = "Class";
            ClassForm.Click += ClassForm_Click;
            ClassForm.MouseEnter += Control_MouseEnter;
            ClassForm.MouseLeave += Control_MouseLeave;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(UserForm);
            panel3.Controls.Add(PaymentForm);
            panel3.Controls.Add(AttendenceForm);
            panel3.Controls.Add(ClassForm);
            panel3.Controls.Add(StudentForm);
            panel3.Location = new Point(122, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 794);
            panel3.TabIndex = 61;
            // 
            // StudentForm
            // 
            StudentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentForm.ForeColor = SystemColors.ControlLightLight;
            StudentForm.Location = new Point(63, 218);
            StudentForm.Name = "StudentForm";
            StudentForm.Size = new Size(157, 30);
            StudentForm.TabIndex = 17;
            StudentForm.Text = "Student";
            StudentForm.Click += StudentForm_Click;
            StudentForm.MouseEnter += Control_MouseEnter;
            StudentForm.MouseLeave += Control_MouseLeave;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(832, 188);
            label15.Name = "label15";
            label15.Size = new Size(355, 35);
            label15.TabIndex = 71;
            label15.Text = "WELCOME TO NKH ";
            // 
            // TStudent
            // 
            TStudent.Anchor = AnchorStyles.None;
            TStudent.BackColor = Color.BlueViolet;
            TStudent.Controls.Add(label2);
            TStudent.Location = new Point(557, 462);
            TStudent.Name = "TStudent";
            TStudent.Size = new Size(313, 54);
            TStudent.TabIndex = 72;
            TStudent.Paint += ShowTotalStudent_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(36, 5);
            label2.Name = "label2";
            label2.Size = new Size(240, 41);
            label2.TabIndex = 76;
            label2.Text = "Total Student";
            // 
            // ShowTotalStudent
            // 
            ShowTotalStudent.Anchor = AnchorStyles.None;
            ShowTotalStudent.BackColor = Color.DarkSlateBlue;
            ShowTotalStudent.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowTotalStudent.ForeColor = Color.Transparent;
            ShowTotalStudent.Location = new Point(557, 310);
            ShowTotalStudent.Name = "ShowTotalStudent";
            ShowTotalStudent.Size = new Size(313, 152);
            ShowTotalStudent.TabIndex = 73;
            ShowTotalStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowTotalTeacher
            // 
            ShowTotalTeacher.Anchor = AnchorStyles.None;
            ShowTotalTeacher.BackColor = Color.DarkSlateBlue;
            ShowTotalTeacher.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowTotalTeacher.ForeColor = Color.Transparent;
            ShowTotalTeacher.Location = new Point(1147, 306);
            ShowTotalTeacher.Name = "ShowTotalTeacher";
            ShowTotalTeacher.Size = new Size(313, 156);
            ShowTotalTeacher.TabIndex = 73;
            ShowTotalTeacher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NetIncome
            // 
            NetIncome.Anchor = AnchorStyles.None;
            NetIncome.BackColor = Color.BlueViolet;
            NetIncome.Controls.Add(label4);
            NetIncome.Location = new Point(557, 761);
            NetIncome.Name = "NetIncome";
            NetIncome.Size = new Size(313, 51);
            NetIncome.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(56, 0);
            label4.Name = "label4";
            label4.Size = new Size(205, 41);
            label4.TabIndex = 78;
            label4.Text = "Net Income";
            // 
            // ShowTotalIncome
            // 
            ShowTotalIncome.Anchor = AnchorStyles.None;
            ShowTotalIncome.BackColor = Color.DarkSlateBlue;
            ShowTotalIncome.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowTotalIncome.ForeColor = Color.Transparent;
            ShowTotalIncome.Location = new Point(557, 609);
            ShowTotalIncome.Name = "ShowTotalIncome";
            ShowTotalIncome.Size = new Size(313, 152);
            ShowTotalIncome.TabIndex = 73;
            ShowTotalIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TDue
            // 
            TDue.Anchor = AnchorStyles.None;
            TDue.BackColor = Color.BlueViolet;
            TDue.Controls.Add(label5);
            TDue.Location = new Point(1147, 761);
            TDue.Name = "TDue";
            TDue.Size = new Size(313, 51);
            TDue.TabIndex = 75;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(126, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 41);
            label5.TabIndex = 78;
            label5.Text = "Due";
            // 
            // ShowTotalDue
            // 
            ShowTotalDue.Anchor = AnchorStyles.None;
            ShowTotalDue.BackColor = Color.DarkSlateBlue;
            ShowTotalDue.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowTotalDue.ForeColor = Color.Transparent;
            ShowTotalDue.Location = new Point(1147, 609);
            ShowTotalDue.Name = "ShowTotalDue";
            ShowTotalDue.Size = new Size(313, 152);
            ShowTotalDue.TabIndex = 73;
            ShowTotalDue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TUser
            // 
            TUser.Anchor = AnchorStyles.None;
            TUser.BackColor = Color.BlueViolet;
            TUser.Controls.Add(label3);
            TUser.Location = new Point(1147, 462);
            TUser.Name = "TUser";
            TUser.Size = new Size(313, 54);
            TUser.TabIndex = 73;
            TUser.Paint += ShowTotalTeacher_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(62, 5);
            label3.Name = "label3";
            label3.Size = new Size(187, 41);
            label3.TabIndex = 77;
            label3.Text = "Total User";
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1718, 974);
            Controls.Add(ShowTotalIncome);
            Controls.Add(ShowTotalDue);
            Controls.Add(ShowTotalTeacher);
            Controls.Add(TDue);
            Controls.Add(NetIncome);
            Controls.Add(TUser);
            Controls.Add(label15);
            Controls.Add(TStudent);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(ShowTotalStudent);
            Name = "Dashbord";
            Text = "Dashbord";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            TStudent.ResumeLayout(false);
            TStudent.PerformLayout();
            NetIncome.ResumeLayout(false);
            NetIncome.PerformLayout();
            TDue.ResumeLayout(false);
            TDue.PerformLayout();
            TUser.ResumeLayout(false);
            TUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel4;
        private Label LogoutBtn;
        private Label PaymentForm;
        private Label UserForm;
        private Label AttendenceForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label ClassForm;
        private Panel panel3;
        private Label StudentForm;
        private Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private Panel TStudent;
        private Label ShowTotalStudent;
        private Label ShowTotalTeacher;
        private Panel NetIncome;
        private Label ShowTotalIncome;
        private Panel TDue;
        private Label ShowTotalDue;
        private Label label2;
        private Panel TUser;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
