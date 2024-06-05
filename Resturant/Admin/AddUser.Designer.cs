namespace Resturant
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd_user = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdoManager = new System.Windows.Forms.RadioButton();
            this.rdoCustomer = new System.Windows.Forms.RadioButton();
            this.rdoChef = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtDateBirth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExperienece = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.labelYearofexperince = new System.Windows.Forms.Label();
            this.txtspeciality = new System.Windows.Forms.TextBox();
            this.labelSpecility = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NAME:";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 1;
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "EMAIL";
            this.label3.UseWaitCursor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(86, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(128, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.UseWaitCursor = true;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(343, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseWaitCursor = true;
            // 
            // btnAdd_user
            // 
            this.btnAdd_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnAdd_user.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_user.ForeColor = System.Drawing.Color.Black;
            this.btnAdd_user.Location = new System.Drawing.Point(3, 284);
            this.btnAdd_user.Name = "btnAdd_user";
            this.btnAdd_user.Size = new System.Drawing.Size(490, 39);
            this.btnAdd_user.TabIndex = 6;
            this.btnAdd_user.Text = "Add User";
            this.btnAdd_user.UseVisualStyleBackColor = false;
            this.btnAdd_user.UseWaitCursor = true;
            this.btnAdd_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(9, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 19);
            this.button2.TabIndex = 7;
            this.button2.Text = "HOME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdoManager
            // 
            this.rdoManager.AutoSize = true;
            this.rdoManager.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoManager.Location = new System.Drawing.Point(434, 211);
            this.rdoManager.Margin = new System.Windows.Forms.Padding(2);
            this.rdoManager.Name = "rdoManager";
            this.rdoManager.Size = new System.Drawing.Size(67, 27);
            this.rdoManager.TabIndex = 8;
            this.rdoManager.TabStop = true;
            this.rdoManager.Text = "Manager";
            this.rdoManager.UseVisualStyleBackColor = true;
            this.rdoManager.UseWaitCursor = true;
            this.rdoManager.CheckedChanged += new System.EventHandler(this.rdoManager_CheckedChanged);
            // 
            // rdoCustomer
            // 
            this.rdoCustomer.AutoEllipsis = true;
            this.rdoCustomer.AutoSize = true;
            this.rdoCustomer.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCustomer.Location = new System.Drawing.Point(277, 211);
            this.rdoCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCustomer.Name = "rdoCustomer";
            this.rdoCustomer.Size = new System.Drawing.Size(72, 27);
            this.rdoCustomer.TabIndex = 9;
            this.rdoCustomer.TabStop = true;
            this.rdoCustomer.Text = "Customer";
            this.rdoCustomer.UseVisualStyleBackColor = true;
            this.rdoCustomer.UseWaitCursor = true;
            this.rdoCustomer.CheckedChanged += new System.EventHandler(this.rdoCustomer_CheckedChanged);
            // 
            // rdoChef
            // 
            this.rdoChef.AutoSize = true;
            this.rdoChef.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChef.Location = new System.Drawing.Point(362, 211);
            this.rdoChef.Margin = new System.Windows.Forms.Padding(2);
            this.rdoChef.Name = "rdoChef";
            this.rdoChef.Size = new System.Drawing.Size(50, 27);
            this.rdoChef.TabIndex = 10;
            this.rdoChef.TabStop = true;
            this.rdoChef.Text = "Chef";
            this.rdoChef.UseVisualStyleBackColor = true;
            this.rdoChef.UseWaitCursor = true;
            this.rdoChef.CheckedChanged += new System.EventHandler(this.rdoChef_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.txtDateBirth);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtExperienece);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.labelYearofexperince);
            this.panel1.Controls.Add(this.txtspeciality);
            this.panel1.Controls.Add(this.labelSpecility);
            this.panel1.Controls.Add(this.rdoManager);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rdoChef);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rdoCustomer);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAdd_user);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(313, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 339);
            this.panel1.TabIndex = 11;
            this.panel1.UseWaitCursor = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 236);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(283, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "______________________________________________";
            this.label11.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "______________________________________________";
            this.label10.UseWaitCursor = true;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(343, 174);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(102, 20);
            this.txtMobile.TabIndex = 29;
            this.txtMobile.UseWaitCursor = true;
            // 
            // txtDateBirth
            // 
            this.txtDateBirth.Location = new System.Drawing.Point(343, 141);
            this.txtDateBirth.Name = "txtDateBirth";
            this.txtDateBirth.Size = new System.Drawing.Size(102, 20);
            this.txtDateBirth.TabIndex = 28;
            this.txtDateBirth.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(263, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mobile";
            this.label14.UseWaitCursor = true;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(263, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Date Of Birth";
            this.label13.UseWaitCursor = true;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtExperienece
            // 
            this.txtExperienece.Location = new System.Drawing.Point(103, 211);
            this.txtExperienece.Name = "txtExperienece";
            this.txtExperienece.Size = new System.Drawing.Size(102, 20);
            this.txtExperienece.TabIndex = 25;
            this.txtExperienece.UseWaitCursor = true;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(10, 173);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(38, 23);
            this.labelSalary.TabIndex = 24;
            this.labelSalary.Text = "Salary";
            this.labelSalary.UseWaitCursor = true;
            this.labelSalary.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(103, 174);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(102, 20);
            this.txtSalary.TabIndex = 23;
            this.txtSalary.UseWaitCursor = true;
            // 
            // labelYearofexperince
            // 
            this.labelYearofexperince.AutoSize = true;
            this.labelYearofexperince.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearofexperince.Location = new System.Drawing.Point(10, 210);
            this.labelYearofexperince.Name = "labelYearofexperince";
            this.labelYearofexperince.Size = new System.Drawing.Size(97, 23);
            this.labelYearofexperince.TabIndex = 22;
            this.labelYearofexperince.Text = "Year Of Experience";
            this.labelYearofexperince.UseWaitCursor = true;
            // 
            // txtspeciality
            // 
            this.txtspeciality.Location = new System.Drawing.Point(103, 141);
            this.txtspeciality.Name = "txtspeciality";
            this.txtspeciality.Size = new System.Drawing.Size(102, 20);
            this.txtspeciality.TabIndex = 21;
            this.txtspeciality.UseWaitCursor = true;
            // 
            // labelSpecility
            // 
            this.labelSpecility.AutoSize = true;
            this.labelSpecility.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecility.Location = new System.Drawing.Point(10, 141);
            this.labelSpecility.Name = "labelSpecility";
            this.labelSpecility.Size = new System.Drawing.Size(52, 23);
            this.labelSpecility.TabIndex = 20;
            this.labelSpecility.Text = "speciality";
            this.labelSpecility.UseWaitCursor = true;
            this.labelSpecility.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-4, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "____________________";
            this.label9.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(208, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "Profile Info";
            this.label8.UseWaitCursor = true;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "_______________________";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "_______________________";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "____________________";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login Info";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 263);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding_manager";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd_user;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdoManager;
        private System.Windows.Forms.RadioButton rdoCustomer;
        private System.Windows.Forms.RadioButton rdoChef;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSpecility;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label labelYearofexperince;
        private System.Windows.Forms.TextBox txtspeciality;
        private System.Windows.Forms.TextBox txtExperienece;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtDateBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}