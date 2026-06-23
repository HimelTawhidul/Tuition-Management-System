namespace NKH_Tution
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ShowPaymentHistoryPanel = new Panel();
            TotalFeeBox = new TextBox();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel3 = new Panel();
            DashbordForm = new Label();
            panel4 = new Panel();
            label14 = new Label();
            UserForm = new Label();
            AttendenceForm = new Label();
            ClassForm = new Label();
            StudentForm = new Label();
            panel2 = new Panel();
            SearchBtn = new Button();
            PaymentOptionBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            StudentIdBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            PaymentBtn = new Button();
            PhostoryPanel = new Label();
            dateTimePicker1 = new DateTimePicker();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            PayableAmountBox = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ShowPaymentHistoryPanel
            // 
            ShowPaymentHistoryPanel.Anchor = AnchorStyles.None;
            ShowPaymentHistoryPanel.BackColor = Color.GhostWhite;
            ShowPaymentHistoryPanel.Location = new Point(459, 533);
            ShowPaymentHistoryPanel.Name = "ShowPaymentHistoryPanel";
            ShowPaymentHistoryPanel.Size = new Size(1160, 296);
            ShowPaymentHistoryPanel.TabIndex = 137;
            // 
            // TotalFeeBox
            // 
            TotalFeeBox.Anchor = AnchorStyles.None;
            TotalFeeBox.Location = new Point(667, 266);
            TotalFeeBox.Name = "TotalFeeBox";
            TotalFeeBox.Size = new Size(259, 31);
            TotalFeeBox.TabIndex = 134;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(662, 231);
            label7.Name = "label7";
            label7.Size = new Size(133, 32);
            label7.TabIndex = 135;
            label7.Text = "Total Fees";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
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
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(DashbordForm);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(UserForm);
            panel3.Controls.Add(AttendenceForm);
            panel3.Controls.Add(ClassForm);
            panel3.Controls.Add(StudentForm);
            panel3.Location = new Point(165, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 780);
            panel3.TabIndex = 118;
            // 
            // DashbordForm
            // 
            DashbordForm.Font = new Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashbordForm.ForeColor = SystemColors.ControlLightLight;
            DashbordForm.Location = new Point(63, 220);
            DashbordForm.Name = "DashbordForm";
            DashbordForm.Size = new Size(190, 30);
            DashbordForm.TabIndex = 144;
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
            label14.Location = new Point(63, 11);
            label14.Name = "label14";
            label14.Size = new Size(125, 33);
            label14.TabIndex = 18;
            label14.Text = "Logout";
            label14.TextAlign = ContentAlignment.MiddleCenter;
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
            // AttendenceForm
            // 
            AttendenceForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttendenceForm.ForeColor = SystemColors.ControlLightLight;
            AttendenceForm.Location = new Point(63, 370);
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
            ClassForm.Location = new Point(63, 327);
            ClassForm.Name = "ClassForm";
            ClassForm.Size = new Size(157, 28);
            ClassForm.TabIndex = 18;
            ClassForm.Text = "Class";
            ClassForm.Click += ClassForm_Click;
            ClassForm.MouseEnter += Control_MouseEnter;
            ClassForm.MouseLeave += Control_MouseLeave;
            // 
            // StudentForm
            // 
            StudentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentForm.ForeColor = SystemColors.ControlLightLight;
            StudentForm.Location = new Point(63, 272);
            StudentForm.Name = "StudentForm";
            StudentForm.Size = new Size(160, 30);
            StudentForm.TabIndex = 17;
            StudentForm.Text = "Student";
            StudentForm.Click += StudentForm_Click;
            StudentForm.MouseEnter += Control_MouseEnter;
            StudentForm.MouseLeave += Control_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Location = new Point(220, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(1564, 813);
            panel2.TabIndex = 1;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.None;
            SearchBtn.BackColor = Color.Red;
            SearchBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.ControlLightLight;
            SearchBtn.Location = new Point(1117, 340);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(121, 47);
            SearchBtn.TabIndex = 136;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            // 
            // PaymentOptionBox
            // 
            PaymentOptionBox.Anchor = AnchorStyles.None;
            PaymentOptionBox.FormattingEnabled = true;
            PaymentOptionBox.Items.AddRange(new object[] { "Full Payment", "Partial Payment" });
            PaymentOptionBox.Location = new Point(1284, 175);
            PaymentOptionBox.Name = "PaymentOptionBox";
            PaymentOptionBox.Size = new Size(253, 33);
            PaymentOptionBox.TabIndex = 131;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(900, 140);
            label4.Name = "label4";
            label4.Size = new Size(195, 32);
            label4.TabIndex = 123;
            label4.Text = "Payment Date";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(1284, 142);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 122;
            label3.Text = "Payment Option";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(474, 142);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 121;
            label2.Text = "Student Id";
            // 
            // StudentIdBox
            // 
            StudentIdBox.Anchor = AnchorStyles.None;
            StudentIdBox.Location = new Point(479, 177);
            StudentIdBox.Name = "StudentIdBox";
            StudentIdBox.Size = new Size(275, 31);
            StudentIdBox.TabIndex = 120;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(777, 57);
            label1.Name = "label1";
            label1.Size = new Size(377, 41);
            label1.TabIndex = 119;
            label1.Text = "PAYMENT SYSTEM\r\n";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(90, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 891);
            panel1.TabIndex = 117;
            // 
            // PaymentBtn
            // 
            PaymentBtn.Anchor = AnchorStyles.None;
            PaymentBtn.BackColor = Color.Red;
            PaymentBtn.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentBtn.ForeColor = SystemColors.ControlLightLight;
            PaymentBtn.Location = new Point(856, 340);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(129, 47);
            PaymentBtn.TabIndex = 128;
            PaymentBtn.Text = "Pay";
            PaymentBtn.UseVisualStyleBackColor = false;
            // 
            // PhostoryPanel
            // 
            PhostoryPanel.Anchor = AnchorStyles.None;
            PhostoryPanel.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhostoryPanel.ForeColor = Color.Transparent;
            PhostoryPanel.Location = new Point(891, 459);
            PhostoryPanel.Name = "PhostoryPanel";
            PhostoryPanel.Size = new Size(285, 35);
            PhostoryPanel.TabIndex = 127;
            PhostoryPanel.Text = "Payment History";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(905, 175);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 31);
            dateTimePicker1.TabIndex = 126;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Anchor = AnchorStyles.None;
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges1;
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(900, 175);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2DateTimePicker1.Size = new Size(263, 33);
            guna2DateTimePicker1.TabIndex = 138;
            guna2DateTimePicker1.Value = new DateTime(2026, 4, 24, 1, 36, 45, 827);
            // 
            // PayableAmountBox
            // 
            PayableAmountBox.Anchor = AnchorStyles.None;
            PayableAmountBox.Location = new Point(1035, 266);
            PayableAmountBox.Name = "PayableAmountBox";
            PayableAmountBox.Size = new Size(259, 31);
            PayableAmountBox.TabIndex = 139;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(1030, 231);
            label5.Name = "label5";
            label5.Size = new Size(223, 32);
            label5.TabIndex = 140;
            label5.Text = "Payable Amount";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1718, 974);
            Controls.Add(PayableAmountBox);
            Controls.Add(label5);
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(ShowPaymentHistoryPanel);
            Controls.Add(TotalFeeBox);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(SearchBtn);
            Controls.Add(PaymentOptionBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(StudentIdBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(PaymentBtn);
            Controls.Add(PhostoryPanel);
            Controls.Add(dateTimePicker1);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ShowPaymentHistoryPanel;
        private TextBox TotalFeeBox;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Label label14;
        private Label UserForm;
        private Label AttendenceForm;
        private Label ClassForm;
        private Label StudentForm;
        private Panel panel2;
        private Button SearchBtn;
        private ComboBox PaymentOptionBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox StudentIdBox;
        private Label label1;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button PaymentBtn;
        private Label PhostoryPanel;
        private DateTimePicker dateTimePicker1;
        private Label DashbordForm;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private TextBox PayableAmountBox;
        private Label label5;
    }
}