namespace NKH_Tution
{
    partial class Attendence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ShowAttendencePanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel3 = new Panel();
            DashbordForm = new Label();
            UserForm = new Label();
            panel4 = new Panel();
            label14 = new Label();
            PaymentForm = new Label();
            StudentForm = new Label();
            ClassForm = new Label();
            panel2 = new Panel();
            EnterBtn = new Button();
            comboBox4 = new ComboBox();
            label18 = new Label();
            showAttendenceBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label15 = new Label();
            dateTimePicker1 = new DateTimePicker();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ShowAttendencePanel
            // 
            ShowAttendencePanel.BackColor = Color.GhostWhite;
            ShowAttendencePanel.Location = new Point(516, 411);
            ShowAttendencePanel.Name = "ShowAttendencePanel";
            ShowAttendencePanel.Size = new Size(1047, 318);
            ShowAttendencePanel.TabIndex = 137;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 116;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCoral;
            panel5.Location = new Point(75, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(223, 141);
            panel5.TabIndex = 75;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(DashbordForm);
            panel3.Controls.Add(UserForm);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(PaymentForm);
            panel3.Controls.Add(StudentForm);
            panel3.Controls.Add(ClassForm);
            panel3.Location = new Point(165, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 780);
            panel3.TabIndex = 118;
            // 
            // DashbordForm
            // 
            DashbordForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashbordForm.ForeColor = SystemColors.ControlLightLight;
            DashbordForm.Location = new Point(33, 242);
            DashbordForm.Name = "DashbordForm";
            DashbordForm.Size = new Size(190, 30);
            DashbordForm.TabIndex = 143;
            DashbordForm.Text = "Dashbord";
            DashbordForm.Click += DashbordForm_Click;
            DashbordForm.MouseEnter += Control_MouseEnter;
            DashbordForm.MouseLeave += Control_MouseLeave;
            // 
            // UserForm
            // 
            UserForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserForm.ForeColor = SystemColors.ControlLightLight;
            UserForm.Location = new Point(33, 443);
            UserForm.Name = "UserForm";
            UserForm.Size = new Size(125, 28);
            UserForm.TabIndex = 142;
            UserForm.Text = "User";
            UserForm.Click += UserForm_Click;
            UserForm.MouseEnter += Control_MouseEnter;
            UserForm.MouseLeave += Control_MouseLeave;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(label14);
            panel4.Location = new Point(0, 722);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 58);
            panel4.TabIndex = 17;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(63, 11);
            label14.Name = "label14";
            label14.Size = new Size(125, 33);
            label14.TabIndex = 18;
            label14.Text = "Logout";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label14.Click += label14_Click;
            // 
            // PaymentForm
            // 
            PaymentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentForm.ForeColor = SystemColors.ControlLightLight;
            PaymentForm.Location = new Point(33, 391);
            PaymentForm.Name = "PaymentForm";
            PaymentForm.Size = new Size(190, 28);
            PaymentForm.TabIndex = 141;
            PaymentForm.Text = "Payment";
            PaymentForm.Click += PaymentForm_Click;
            PaymentForm.MouseEnter += Control_MouseEnter;
            PaymentForm.MouseLeave += Control_MouseLeave;
            // 
            // StudentForm
            // 
            StudentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentForm.ForeColor = SystemColors.ControlLightLight;
            StudentForm.Location = new Point(33, 291);
            StudentForm.Name = "StudentForm";
            StudentForm.Size = new Size(190, 30);
            StudentForm.TabIndex = 138;
            StudentForm.Text = "Student";
            StudentForm.Click += StudentForm_Click;
            StudentForm.MouseEnter += Control_MouseEnter;
            StudentForm.MouseLeave += Control_MouseLeave;
            // 
            // ClassForm
            // 
            ClassForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassForm.ForeColor = SystemColors.ControlLightLight;
            ClassForm.Location = new Point(33, 341);
            ClassForm.Name = "ClassForm";
            ClassForm.Size = new Size(190, 28);
            ClassForm.TabIndex = 139;
            ClassForm.Text = "Class";
            ClassForm.Click += ClassForm_Click;
            ClassForm.MouseEnter += Control_MouseEnter;
            ClassForm.MouseLeave += Control_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Location = new Point(220, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1564, 813);
            panel2.TabIndex = 1;
            // 
            // EnterBtn
            // 
            EnterBtn.BackColor = Color.Red;
            EnterBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnterBtn.ForeColor = SystemColors.ControlLightLight;
            EnterBtn.Location = new Point(892, 243);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(174, 47);
            EnterBtn.TabIndex = 136;
            EnterBtn.Text = "Enter";
            EnterBtn.UseVisualStyleBackColor = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Male", "Female" });
            comboBox4.Location = new Point(1252, 178);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(276, 33);
            comboBox4.TabIndex = 133;
            // 
            // label18
            // 
            label18.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(1247, 143);
            label18.Name = "label18";
            label18.Size = new Size(207, 32);
            label18.TabIndex = 132;
            label18.Text = "Section";
            // 
            // showAttendenceBox
            // 
            showAttendenceBox.FormattingEnabled = true;
            showAttendenceBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            showAttendenceBox.Location = new Point(911, 176);
            showAttendenceBox.Name = "showAttendenceBox";
            showAttendenceBox.Size = new Size(269, 33);
            showAttendenceBox.TabIndex = 131;
            // 
            // label4
            // 
            label4.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(516, 143);
            label4.Name = "label4";
            label4.Size = new Size(338, 34);
            label4.TabIndex = 123;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(911, 143);
            label3.Name = "label3";
            label3.Size = new Size(198, 32);
            label3.TabIndex = 122;
            label3.Text = "Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(847, 56);
            label1.Name = "label1";
            label1.Size = new Size(291, 41);
            label1.TabIndex = 119;
            label1.Text = "ATTENDENCE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(90, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 891);
            panel1.TabIndex = 117;
            // 
            // label15
            // 
            label15.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(892, 335);
            label15.Name = "label15";
            label15.Size = new Size(314, 35);
            label15.TabIndex = 127;
            label15.Text = "Attendence List";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(521, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 31);
            dateTimePicker1.TabIndex = 126;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges3;
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(516, 178);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2DateTimePicker1.Size = new Size(338, 33);
            guna2DateTimePicker1.TabIndex = 138;
            guna2DateTimePicker1.Value = new DateTime(2026, 4, 24, 1, 37, 38, 150);
            // 
            // Attendence
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1718, 974);
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(ShowAttendencePanel);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(EnterBtn);
            Controls.Add(comboBox4);
            Controls.Add(label18);
            Controls.Add(showAttendenceBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label15);
            Controls.Add(dateTimePicker1);
            Name = "Attendence";
            Text = "Attendence";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ShowAttendencePanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Label label14;
        private Panel panel2;
        private Button EnterBtn;
        private ComboBox comboBox4;
        private Label label18;
        private ComboBox showAttendenceBox;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label15;
        private DateTimePicker dateTimePicker1;
        private Label UserForm;
        private Label PaymentForm;
        private Label StudentForm;
        private Label ClassForm;
        private Label DashbordForm;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}