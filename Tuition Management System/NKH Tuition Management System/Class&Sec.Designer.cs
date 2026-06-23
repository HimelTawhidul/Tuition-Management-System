namespace NKH_Tution
{
    partial class Class_Sec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class_Sec));
            ClassShowPanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel3 = new Panel();
            DashbordForm = new Label();
            UserForm = new Label();
            panel4 = new Panel();
            label14 = new Label();
            PaymentForm = new Label();
            AttendenceForm = new Label();
            StudentForm = new Label();
            panel2 = new Panel();
            SectionBox = new ComboBox();
            label18 = new Label();
            label2 = new Label();
            NameBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            AddSectionBtn = new Button();
            AddClassBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ClassShowPanel
            // 
            ClassShowPanel.BackColor = Color.GhostWhite;
            ClassShowPanel.Location = new Point(432, 392);
            ClassShowPanel.Margin = new Padding(2, 2, 2, 2);
            ClassShowPanel.Name = "ClassShowPanel";
            ClassShowPanel.Size = new Size(856, 300);
            ClassShowPanel.TabIndex = 137;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 57);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 116;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCoral;
            panel5.Location = new Point(60, 23);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(178, 113);
            panel5.TabIndex = 75;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(DashbordForm);
            panel3.Controls.Add(UserForm);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(PaymentForm);
            panel3.Controls.Add(AttendenceForm);
            panel3.Controls.Add(StudentForm);
            panel3.Location = new Point(132, 96);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 624);
            panel3.TabIndex = 118;
            // 
            // DashbordForm
            // 
            DashbordForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashbordForm.ForeColor = SystemColors.ControlLightLight;
            DashbordForm.Location = new Point(26, 182);
            DashbordForm.Margin = new Padding(2, 0, 2, 0);
            DashbordForm.Name = "DashbordForm";
            DashbordForm.Size = new Size(152, 24);
            DashbordForm.TabIndex = 144;
            DashbordForm.Text = "Dashbord";
            DashbordForm.Click += DashbordForm_Click;
            DashbordForm.MouseEnter += Control_MouseEnter;
            DashbordForm.MouseLeave += Control_MouseLeave;
            // 
            // UserForm
            // 
            UserForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserForm.ForeColor = SystemColors.ControlLightLight;
            UserForm.Location = new Point(26, 347);
            UserForm.Margin = new Padding(2, 0, 2, 0);
            UserForm.Name = "UserForm";
            UserForm.Size = new Size(100, 22);
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
            panel4.Location = new Point(0, 578);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 46);
            panel4.TabIndex = 17;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(50, 9);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 26);
            label14.TabIndex = 18;
            label14.Text = "Logout";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymentForm
            // 
            PaymentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentForm.ForeColor = SystemColors.ControlLightLight;
            PaymentForm.Location = new Point(26, 267);
            PaymentForm.Margin = new Padding(2, 0, 2, 0);
            PaymentForm.Name = "PaymentForm";
            PaymentForm.Size = new Size(152, 22);
            PaymentForm.TabIndex = 141;
            PaymentForm.Text = "Payment";
            PaymentForm.Click += PaymentForm_Click;
            PaymentForm.MouseEnter += Control_MouseEnter;
            PaymentForm.MouseLeave += Control_MouseLeave;
            // 
            // AttendenceForm
            // 
            AttendenceForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttendenceForm.ForeColor = SystemColors.ControlLightLight;
            AttendenceForm.Location = new Point(26, 307);
            AttendenceForm.Margin = new Padding(2, 0, 2, 0);
            AttendenceForm.Name = "AttendenceForm";
            AttendenceForm.Size = new Size(152, 22);
            AttendenceForm.TabIndex = 140;
            AttendenceForm.Text = "Attendence";
            AttendenceForm.Click += AttendenceForm_Click;
            AttendenceForm.MouseEnter += Control_MouseEnter;
            AttendenceForm.MouseLeave += Control_MouseLeave;
            // 
            // StudentForm
            // 
            StudentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentForm.ForeColor = SystemColors.ControlLightLight;
            StudentForm.Location = new Point(26, 220);
            StudentForm.Margin = new Padding(2, 0, 2, 0);
            StudentForm.Name = "StudentForm";
            StudentForm.Size = new Size(152, 24);
            StudentForm.TabIndex = 138;
            StudentForm.Text = "Student";
            StudentForm.Click += StudentForm_Click;
            StudentForm.MouseEnter += Control_MouseEnter;
            StudentForm.MouseLeave += Control_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Location = new Point(176, 47);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1251, 650);
            panel2.TabIndex = 1;
            // 
            // SectionBox
            // 
            SectionBox.FormattingEnabled = true;
            SectionBox.Items.AddRange(new object[] { "Male", "Female" });
            SectionBox.Location = new Point(498, 218);
            SectionBox.Margin = new Padding(2, 2, 2, 2);
            SectionBox.Name = "SectionBox";
            SectionBox.Size = new Size(192, 28);
            SectionBox.TabIndex = 133;
            // 
            // label18
            // 
            label18.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(494, 190);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(118, 26);
            label18.TabIndex = 132;
            label18.Text = "Section";
            // 
            // label2
            // 
            label2.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(490, 117);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 26);
            label2.TabIndex = 121;
            label2.Text = "Name";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(494, 145);
            NameBox.Margin = new Padding(2, 2, 2, 2);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(270, 27);
            NameBox.TabIndex = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(622, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(346, 35);
            label1.TabIndex = 119;
            label1.Text = "CLASS AND SECTION";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(72, 34);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 713);
            panel1.TabIndex = 117;
            // 
            // AddSectionBtn
            // 
            AddSectionBtn.BackColor = Color.Red;
            AddSectionBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddSectionBtn.ForeColor = SystemColors.ControlLightLight;
            AddSectionBtn.Location = new Point(726, 297);
            AddSectionBtn.Margin = new Padding(2, 2, 2, 2);
            AddSectionBtn.Name = "AddSectionBtn";
            AddSectionBtn.Size = new Size(102, 38);
            AddSectionBtn.TabIndex = 129;
            AddSectionBtn.Text = "Delete";
            AddSectionBtn.UseVisualStyleBackColor = false;
            // 
            // AddClassBtn
            // 
            AddClassBtn.BackColor = Color.Red;
            AddClassBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddClassBtn.ForeColor = SystemColors.ControlLightLight;
            AddClassBtn.Location = new Point(498, 297);
            AddClassBtn.Margin = new Padding(2, 2, 2, 2);
            AddClassBtn.Name = "AddClassBtn";
            AddClassBtn.Size = new Size(103, 38);
            AddClassBtn.TabIndex = 128;
            AddClassBtn.Text = "Add";
            AddClassBtn.UseVisualStyleBackColor = false;
            AddClassBtn.Click += button1_Click;
            // 
            // Class_Sec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1374, 779);
            Controls.Add(ClassShowPanel);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(SectionBox);
            Controls.Add(label18);
            Controls.Add(label2);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(AddSectionBtn);
            Controls.Add(AddClassBtn);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Class_Sec";
            Text = "Class_Sec";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ClassShowPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Label label14;
        private Panel panel2;
        private ComboBox SectionBox;
        private Label label18;
        private Label label2;
        private TextBox NameBox;
        private Label label1;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button AddSectionBtn;
        private Button AddClassBtn;
        private Label UserForm;
        private Label PaymentForm;
        private Label AttendenceForm;
        private Label StudentForm;
        private Label DashbordForm;
    }
}