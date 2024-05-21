namespace Resturant.manage
{
    partial class frmViewReservations
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.grpReservationDetails = new System.Windows.Forms.GroupBox();
            this.chbxIncludeDate = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dntDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.txtHourIn = new System.Windows.Forms.TextBox();
            this.txtMinuteIn = new System.Windows.Forms.TextBox();
            this.btnAMPMIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHourOut = new System.Windows.Forms.TextBox();
            this.txtMinuteOut = new System.Windows.Forms.TextBox();
            this.btnAMPMOut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.grpReservationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AllowUserToOrderColumns = true;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(12, 186);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.Size = new System.Drawing.Size(776, 252);
            this.dgvReservations.TabIndex = 0;
            // 
            // grpReservationDetails
            // 
            this.grpReservationDetails.Controls.Add(this.txtHourOut);
            this.grpReservationDetails.Controls.Add(this.txtMinuteOut);
            this.grpReservationDetails.Controls.Add(this.btnAMPMOut);
            this.grpReservationDetails.Controls.Add(this.label5);
            this.grpReservationDetails.Controls.Add(this.label1);
            this.grpReservationDetails.Controls.Add(this.chbxIncludeDate);
            this.grpReservationDetails.Controls.Add(this.btnSubmit);
            this.grpReservationDetails.Controls.Add(this.label4);
            this.grpReservationDetails.Controls.Add(this.dntDate);
            this.grpReservationDetails.Controls.Add(this.txtNumberOfPeople);
            this.grpReservationDetails.Controls.Add(this.txtHourIn);
            this.grpReservationDetails.Controls.Add(this.txtMinuteIn);
            this.grpReservationDetails.Controls.Add(this.btnAMPMIn);
            this.grpReservationDetails.Controls.Add(this.label2);
            this.grpReservationDetails.Controls.Add(this.label3);
            this.grpReservationDetails.Location = new System.Drawing.Point(12, 12);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Size = new System.Drawing.Size(776, 166);
            this.grpReservationDetails.TabIndex = 12;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation Details";
            // 
            // chbxIncludeDate
            // 
            this.chbxIncludeDate.AutoSize = true;
            this.chbxIncludeDate.Location = new System.Drawing.Point(400, 55);
            this.chbxIncludeDate.Name = "chbxIncludeDate";
            this.chbxIncludeDate.Size = new System.Drawing.Size(118, 17);
            this.chbxIncludeDate.TabIndex = 12;
            this.chbxIncludeDate.Text = "Include date in filter";
            this.chbxIncludeDate.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(261, 137);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(185, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Filter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of people:";
            // 
            // dntDate
            // 
            this.dntDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dntDate.Location = new System.Drawing.Point(189, 55);
            this.dntDate.MinDate = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            this.dntDate.Name = "dntDate";
            this.dntDate.Size = new System.Drawing.Size(184, 20);
            this.dntDate.TabIndex = 2;
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfPeople.Location = new System.Drawing.Point(425, 17);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(103, 20);
            this.txtNumberOfPeople.TabIndex = 9;
            // 
            // txtHourIn
            // 
            this.txtHourIn.ForeColor = System.Drawing.Color.Gray;
            this.txtHourIn.Location = new System.Drawing.Point(34, 98);
            this.txtHourIn.Name = "txtHourIn";
            this.txtHourIn.Size = new System.Drawing.Size(84, 20);
            this.txtHourIn.TabIndex = 3;
            this.txtHourIn.Text = "HH";
            this.txtHourIn.TextChanged += new System.EventHandler(this.txtHour_TextChanged_1);
            this.txtHourIn.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtHourIn.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // txtMinuteIn
            // 
            this.txtMinuteIn.ForeColor = System.Drawing.Color.Gray;
            this.txtMinuteIn.Location = new System.Drawing.Point(145, 98);
            this.txtMinuteIn.Name = "txtMinuteIn";
            this.txtMinuteIn.Size = new System.Drawing.Size(80, 20);
            this.txtMinuteIn.TabIndex = 4;
            this.txtMinuteIn.Text = "MM";
            this.txtMinuteIn.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            this.txtMinuteIn.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtMinuteIn.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // btnAMPMIn
            // 
            this.btnAMPMIn.BackColor = System.Drawing.Color.Gold;
            this.btnAMPMIn.Location = new System.Drawing.Point(231, 98);
            this.btnAMPMIn.Name = "btnAMPMIn";
            this.btnAMPMIn.Size = new System.Drawing.Size(76, 20);
            this.btnAMPMIn.TabIndex = 7;
            this.btnAMPMIn.Text = "AM";
            this.btnAMPMIn.UseVisualStyleBackColor = false;
            this.btnAMPMIn.Click += new System.EventHandler(this.btnAMPM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "date and time of reservation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "to";
            // 
            // txtHourOut
            // 
            this.txtHourOut.ForeColor = System.Drawing.Color.Gray;
            this.txtHourOut.Location = new System.Drawing.Point(400, 98);
            this.txtHourOut.Name = "txtHourOut";
            this.txtHourOut.Size = new System.Drawing.Size(84, 20);
            this.txtHourOut.TabIndex = 14;
            this.txtHourOut.Text = "HH";
            // 
            // txtMinuteOut
            // 
            this.txtMinuteOut.ForeColor = System.Drawing.Color.Gray;
            this.txtMinuteOut.Location = new System.Drawing.Point(511, 98);
            this.txtMinuteOut.Name = "txtMinuteOut";
            this.txtMinuteOut.Size = new System.Drawing.Size(80, 20);
            this.txtMinuteOut.TabIndex = 15;
            this.txtMinuteOut.Text = "MM";
            // 
            // btnAMPMOut
            // 
            this.btnAMPMOut.BackColor = System.Drawing.Color.Gold;
            this.btnAMPMOut.Location = new System.Drawing.Point(597, 98);
            this.btnAMPMOut.Name = "btnAMPMOut";
            this.btnAMPMOut.Size = new System.Drawing.Size(76, 20);
            this.btnAMPMOut.TabIndex = 17;
            this.btnAMPMOut.Text = "AM";
            this.btnAMPMOut.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = ":";
            // 
            // frmViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpReservationDetails);
            this.Controls.Add(this.dgvReservations);
            this.Name = "frmViewReservations";
            this.Text = "frmViewReservations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.grpReservationDetails.ResumeLayout(false);
            this.grpReservationDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.GroupBox grpReservationDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dntDate;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.TextBox txtHourIn;
        private System.Windows.Forms.TextBox txtMinuteIn;
        private System.Windows.Forms.Button btnAMPMIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chbxIncludeDate;
        private System.Windows.Forms.TextBox txtHourOut;
        private System.Windows.Forms.TextBox txtMinuteOut;
        private System.Windows.Forms.Button btnAMPMOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}