namespace NKH_Tution
{
    partial class StudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManagement));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PaymentForm = new Label();
            AttendenceForm = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ClassForm = new Label();
            pictureBox1 = new PictureBox();
            UserForm = new Label();
            panel3 = new Panel();
            DashbordForm = new Label();
            panel4 = new Panel();
            label14 = new Label();
            SectionBox = new ComboBox();
            SectionLabel = new Label();
            ClassBox = new ComboBox();
            AddressBox = new TextBox();
            DOBLabel = new Label();
            ClassLabel = new Label();
            NameLabel = new Label();
            NameBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            AddressLabel = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            AddBtn = new Button();
            label15 = new Label();
            dateTimePicker1 = new DateTimePicker();
            PhoneBox = new TextBox();
            PhoneLabel = new Label();
            SearchBtn = new Button();
            StudentShowPanel = new Panel();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DownloadBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PaymentForm
            // 
            PaymentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentForm.ForeColor = SystemColors.ControlLightLight;
            PaymentForm.Location = new Point(63, 320);
            PaymentForm.Name = "PaymentForm";
            PaymentForm.Size = new Size(190, 28);
            PaymentForm.TabIndex = 20;
            PaymentForm.Text = "Payment";
            PaymentForm.Click += PaymentForm_Click;
            PaymentForm.MouseEnter += Control_MouseEnter;
            PaymentForm.MouseLeave += Control_MouseLeave;
            // 
            // AttendenceForm
            // 
            AttendenceForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttendenceForm.ForeColor = SystemColors.ControlLightLight;
            AttendenceForm.Location = new Point(63, 370);
            AttendenceForm.Name = "AttendenceForm";
            AttendenceForm.Size = new Size(190, 28);
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
            ClassForm.Location = new Point(63, 270);
            ClassForm.Name = "ClassForm";
            ClassForm.Size = new Size(190, 28);
            ClassForm.TabIndex = 18;
            ClassForm.Text = "Class";
            ClassForm.Click += ClassForm_Click;
            ClassForm.MouseEnter += Control_MouseEnter;
            ClassForm.MouseLeave += Control_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 86;
            pictureBox1.TabStop = false;
            // 
            // UserForm
            // 
            UserForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserForm.ForeColor = SystemColors.ControlLightLight;
            UserForm.Location = new Point(63, 420);
            UserForm.Name = "UserForm";
            UserForm.Size = new Size(125, 28);
            UserForm.TabIndex = 21;
            UserForm.Text = "User";
            UserForm.Click += UserForm_Click;
            UserForm.MouseEnter += Control_MouseEnter;
            UserForm.MouseLeave += Control_MouseLeave;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(DashbordForm);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(UserForm);
            panel3.Controls.Add(PaymentForm);
            panel3.Controls.Add(AttendenceForm);
            panel3.Controls.Add(ClassForm);
            panel3.Location = new Point(122, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 780);
            panel3.TabIndex = 88;
            panel3.MouseEnter += Control_MouseEnter;
            panel3.MouseLeave += Control_MouseLeave;
            // 
            // DashbordForm
            // 
            DashbordForm.Font = new Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashbordForm.ForeColor = SystemColors.ControlLightLight;
            DashbordForm.Location = new Point(60, 220);
            DashbordForm.Name = "DashbordForm";
            DashbordForm.Size = new Size(163, 38);
            DashbordForm.TabIndex = 145;
            DashbordForm.Text = "Dashbord";
            DashbordForm.Click += DashbordForm_Click;
            DashbordForm.MouseEnter += Control_MouseEnter;
            DashbordForm.MouseLeave += Control_MouseLeave;
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
            label14.Location = new Point(50, 11);
            label14.Name = "label14";
            label14.Size = new Size(125, 33);
            label14.TabIndex = 18;
            label14.Text = "Logout";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SectionBox
            // 
            SectionBox.Anchor = AnchorStyles.None;
            SectionBox.FormattingEnabled = true;
            SectionBox.Items.AddRange(new object[] { "A", "B", "C", "D", "1", "2" });
            SectionBox.Location = new Point(1077, 180);
            SectionBox.Name = "SectionBox";
            SectionBox.Size = new Size(259, 33);
            SectionBox.TabIndex = 109;
            // 
            // SectionLabel
            // 
            SectionLabel.Anchor = AnchorStyles.None;
            SectionLabel.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SectionLabel.ForeColor = SystemColors.ControlLightLight;
            SectionLabel.Location = new Point(1077, 144);
            SectionLabel.Name = "SectionLabel";
            SectionLabel.Size = new Size(229, 34);
            SectionLabel.TabIndex = 108;
            SectionLabel.Text = "Section";
            // 
            // ClassBox
            // 
            ClassBox.Anchor = AnchorStyles.None;
            ClassBox.FormattingEnabled = true;
            ClassBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            ClassBox.Location = new Point(775, 179);
            ClassBox.Name = "ClassBox";
            ClassBox.Size = new Size(273, 33);
            ClassBox.TabIndex = 102;
            // 
            // AddressBox
            // 
            AddressBox.Anchor = AnchorStyles.None;
            AddressBox.Location = new Point(1085, 263);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(312, 31);
            AddressBox.TabIndex = 94;
            // 
            // DOBLabel
            // 
            DOBLabel.Anchor = AnchorStyles.None;
            DOBLabel.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DOBLabel.ForeColor = SystemColors.ControlLightLight;
            DOBLabel.Location = new Point(625, 226);
            DOBLabel.Name = "DOBLabel";
            DOBLabel.Size = new Size(259, 32);
            DOBLabel.TabIndex = 93;
            DOBLabel.Text = "Date Of Birth";
            // 
            // ClassLabel
            // 
            ClassLabel.Anchor = AnchorStyles.None;
            ClassLabel.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassLabel.ForeColor = SystemColors.ControlLightLight;
            ClassLabel.Location = new Point(775, 146);
            ClassLabel.Name = "ClassLabel";
            ClassLabel.Size = new Size(202, 32);
            ClassLabel.TabIndex = 92;
            ClassLabel.Text = "Class";
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.None;
            NameLabel.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = SystemColors.ControlLightLight;
            NameLabel.Location = new Point(393, 146);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(231, 32);
            NameLabel.TabIndex = 91;
            NameLabel.Text = "Name";
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.None;
            NameBox.Location = new Point(398, 181);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(340, 31);
            NameBox.TabIndex = 90;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(734, 57);
            label1.Name = "label1";
            label1.Size = new Size(502, 41);
            label1.TabIndex = 89;
            label1.Text = "STUDENT MANAGEMENT";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(47, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 891);
            panel1.TabIndex = 87;
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
            // AddressLabel
            // 
            AddressLabel.Anchor = AnchorStyles.None;
            AddressLabel.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressLabel.ForeColor = SystemColors.ControlLightLight;
            AddressLabel.Location = new Point(1080, 228);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(186, 32);
            AddressLabel.TabIndex = 95;
            AddressLabel.Text = "Address";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.None;
            UpdateBtn.BackColor = Color.Red;
            UpdateBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = SystemColors.ControlLightLight;
            UpdateBtn.Location = new Point(810, 331);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(181, 47);
            UpdateBtn.TabIndex = 101;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.None;
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = SystemColors.ControlLightLight;
            DeleteBtn.Location = new Point(1046, 332);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(181, 47);
            DeleteBtn.TabIndex = 100;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.BackColor = Color.Red;
            AddBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = SystemColors.ControlLightLight;
            AddBtn.Location = new Point(585, 332);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(182, 47);
            AddBtn.TabIndex = 99;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(914, 423);
            label15.Name = "label15";
            label15.Size = new Size(285, 35);
            label15.TabIndex = 98;
            label15.Text = "Student List";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(630, 261);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 31);
            dateTimePicker1.TabIndex = 97;
            // 
            // PhoneBox
            // 
            PhoneBox.Anchor = AnchorStyles.None;
            PhoneBox.Location = new Point(1379, 181);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(269, 31);
            PhoneBox.TabIndex = 112;
            // 
            // PhoneLabel
            // 
            PhoneLabel.Anchor = AnchorStyles.None;
            PhoneLabel.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneLabel.ForeColor = SystemColors.ControlLightLight;
            PhoneLabel.Location = new Point(1374, 146);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(214, 32);
            PhoneLabel.TabIndex = 113;
            PhoneLabel.Text = "Phone";
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.None;
            SearchBtn.BackColor = Color.Red;
            SearchBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.ControlLightLight;
            SearchBtn.Location = new Point(1268, 332);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(174, 47);
            SearchBtn.TabIndex = 114;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // StudentShowPanel
            // 
            StudentShowPanel.Anchor = AnchorStyles.None;
            StudentShowPanel.BackColor = Color.GhostWhite;
            StudentShowPanel.Location = new Point(373, 490);
            StudentShowPanel.Name = "StudentShowPanel";
            StudentShowPanel.Size = new Size(1299, 361);
            StudentShowPanel.TabIndex = 115;
            StudentShowPanel.Paint += StudentShowPanel_Paint;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Anchor = AnchorStyles.None;
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges1;
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(630, 261);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2DateTimePicker1.Size = new Size(350, 33);
            guna2DateTimePicker1.TabIndex = 139;
            guna2DateTimePicker1.Value = new DateTime(2026, 4, 24, 1, 37, 38, 150);
            // 
            // DownloadBtn
            // 
            DownloadBtn.Anchor = AnchorStyles.None;
            DownloadBtn.BackColor = Color.DarkGreen;
            DownloadBtn.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DownloadBtn.ForeColor = Color.White;
            DownloadBtn.Location = new Point(1268, 400);
            DownloadBtn.Name = "DownloadBtn";
            DownloadBtn.Size = new Size(174, 47);
            DownloadBtn.TabIndex = 115;
            DownloadBtn.Text = "Download CSV";
            DownloadBtn.UseVisualStyleBackColor = false;
            DownloadBtn.Click += DownloadBtn_Click;
            // 
            // StudentManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1699, 974);
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(StudentShowPanel);
            Controls.Add(SearchBtn);
            Controls.Add(PhoneBox);
            Controls.Add(PhoneLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(SectionBox);
            Controls.Add(SectionLabel);
            Controls.Add(ClassBox);
            Controls.Add(AddressBox);
            Controls.Add(DOBLabel);
            Controls.Add(ClassLabel);
            Controls.Add(NameLabel);
            Controls.Add(NameBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(AddressLabel);
            Controls.Add(UpdateBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(label15);
            Controls.Add(dateTimePicker1);
            Controls.Add(DownloadBtn);
            Name = "StudentManagement";
            Text = "StudentManagement";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PaymentForm;
        private Label AttendenceForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label ClassForm;
        private PictureBox pictureBox1;
        private Label UserForm;
        private Panel panel3;
        private Panel panel4;
        private Label label14;
        private ComboBox SectionBox;
        private Label SectionLabel;
        private ComboBox ClassBox;
        private TextBox AddressBox;
        private Label DOBLabel;
        private Label ClassLabel;
        private Label NameLabel;
        private TextBox NameBox;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label AddressLabel;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddBtn;
        private Button DownloadBtn;
        private Label label15;
        private DateTimePicker dateTimePicker1;
        private TextBox PhoneBox;
        private Label PhoneLabel;
        private Button SearchBtn;
        private Panel StudentShowPanel;
        private Label DashbordForm;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}