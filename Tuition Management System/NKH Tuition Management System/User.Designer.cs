namespace NKH_Tution
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            studentShowPanel = new Panel();
            textBox2 = new TextBox();
            label7 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            panel3 = new Panel();
            DashbordForm = new Label();
            panel4 = new Panel();
            label14 = new Label();
            PaymentForm = new Label();
            AttendenceForm = new Label();
            StudentForm = new Label();
            ClassForm = new Label();
            panel2 = new Panel();
            comboBox4 = new ComboBox();
            label18 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            button1 = new Button();
            label15 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // studentShowPanel
            // 
            studentShowPanel.BackColor = Color.GhostWhite;
            studentShowPanel.Location = new Point(501, 440);
            studentShowPanel.Name = "studentShowPanel";
            studentShowPanel.Size = new Size(1064, 372);
            studentShowPanel.TabIndex = 137;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(942, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 31);
            textBox2.TabIndex = 134;
            // 
            // label7
            // 
            label7.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(937, 142);
            label7.Name = "label7";
            label7.Size = new Size(133, 32);
            label7.TabIndex = 135;
            label7.Text = "Password";
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
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(PaymentForm);
            panel3.Controls.Add(AttendenceForm);
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
            DashbordForm.Location = new Point(33, 240);
            DashbordForm.Name = "DashbordForm";
            DashbordForm.Size = new Size(190, 30);
            DashbordForm.TabIndex = 146;
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
            label14.Location = new Point(63, 10);
            label14.Name = "label14";
            label14.Size = new Size(125, 33);
            label14.TabIndex = 18;
            label14.Text = "Logout";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymentForm
            // 
            PaymentForm.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentForm.ForeColor = SystemColors.ControlLightLight;
            PaymentForm.Location = new Point(33, 386);
            PaymentForm.Name = "PaymentForm";
            PaymentForm.Size = new Size(190, 28);
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
            AttendenceForm.Location = new Point(33, 436);
            AttendenceForm.Name = "AttendenceForm";
            AttendenceForm.Size = new Size(190, 28);
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
            StudentForm.Location = new Point(33, 286);
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
            ClassForm.Location = new Point(33, 336);
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
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Male", "Female" });
            comboBox4.Location = new Point(1320, 175);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(217, 33);
            comboBox4.TabIndex = 133;
            // 
            // label18
            // 
            label18.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(1315, 140);
            label18.Name = "label18";
            label18.Size = new Size(148, 32);
            label18.TabIndex = 132;
            label18.Text = "Role";
            // 
            // label2
            // 
            label2.Font = new Font("Elephant", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(555, 142);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 121;
            label2.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(560, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 31);
            textBox1.TabIndex = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(777, 57);
            label1.Name = "label1";
            label1.Size = new Size(420, 41);
            label1.TabIndex = 119;
            label1.Text = "USER MANAGEMENT";
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
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1152, 272);
            button2.Name = "button2";
            button2.Size = new Size(128, 47);
            button2.TabIndex = 129;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(737, 272);
            button1.Name = "button1";
            button1.Size = new Size(129, 47);
            button1.TabIndex = 128;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            label15.Font = new Font("Elephant", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(942, 383);
            label15.Name = "label15";
            label15.Size = new Size(176, 35);
            label15.TabIndex = 127;
            label15.Text = "User List";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(942, 272);
            button3.Name = "button3";
            button3.Size = new Size(128, 47);
            button3.TabIndex = 130;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1718, 974);
            Controls.Add(studentShowPanel);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(comboBox4);
            Controls.Add(label18);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label15);
            Name = "User";
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel studentShowPanel;
        private TextBox textBox2;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private Label label14;
        private Panel panel2;
        private ComboBox comboBox4;
        private Label label18;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button2;
        private Button button1;
        private Label label15;
        private Button button3;
        private Label PaymentForm;
        private Label AttendenceForm;
        private Label StudentForm;
        private Label ClassForm;
        private Label DashbordForm;
    }
}