namespace Resturant
{
    partial class NewReservation
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dntDate = new System.Windows.Forms.DateTimePicker();
            this.txtHourFrom = new System.Windows.Forms.TextBox();
            this.txtMinuteFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAMPMFrom = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpReservationDetails = new System.Windows.Forms.GroupBox();
            this.TO = new System.Windows.Forms.Label();
            this.txtHourTo = new System.Windows.Forms.TextBox();
            this.txtMinuteTo = new System.Windows.Forms.TextBox();
            this.btnAMPMTo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpReservationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 24;
            this.lstCustomers.Location = new System.Drawing.Point(19, 39);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(372, 172);
            this.lstCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer to reserve";
            // 
            // dntDate
            // 
            this.dntDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dntDate.Location = new System.Drawing.Point(10, 93);
            this.dntDate.MinDate = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            this.dntDate.Name = "dntDate";
            this.dntDate.Size = new System.Drawing.Size(356, 29);
            this.dntDate.TabIndex = 2;
            // 
            // txtHourFrom
            // 
            this.txtHourFrom.ForeColor = System.Drawing.Color.Gray;
            this.txtHourFrom.Location = new System.Drawing.Point(10, 126);
            this.txtHourFrom.Name = "txtHourFrom";
            this.txtHourFrom.Size = new System.Drawing.Size(34, 29);
            this.txtHourFrom.TabIndex = 3;
            this.txtHourFrom.Text = "HH";
            this.txtHourFrom.TextChanged += new System.EventHandler(this.txtHour_TextChanged_1);
            this.txtHourFrom.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtHourFrom.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // txtMinuteFrom
            // 
            this.txtMinuteFrom.ForeColor = System.Drawing.Color.Gray;
            this.txtMinuteFrom.Location = new System.Drawing.Point(71, 126);
            this.txtMinuteFrom.Name = "txtMinuteFrom";
            this.txtMinuteFrom.Size = new System.Drawing.Size(40, 29);
            this.txtMinuteFrom.TabIndex = 4;
            this.txtMinuteFrom.Text = "MM";
            this.txtMinuteFrom.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            this.txtMinuteFrom.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtMinuteFrom.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "date and time of reservation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // btnAMPMFrom
            // 
            this.btnAMPMFrom.BackColor = System.Drawing.Color.Gold;
            this.btnAMPMFrom.Location = new System.Drawing.Point(117, 126);
            this.btnAMPMFrom.Name = "btnAMPMFrom";
            this.btnAMPMFrom.Size = new System.Drawing.Size(49, 31);
            this.btnAMPMFrom.TabIndex = 7;
            this.btnAMPMFrom.Text = "AM";
            this.btnAMPMFrom.UseVisualStyleBackColor = false;
            this.btnAMPMFrom.Click += new System.EventHandler(this.btnAMPM_Click);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.Color.DarkGray;
            this.btnMakeReservation.ForeColor = System.Drawing.Color.Black;
            this.btnMakeReservation.Location = new System.Drawing.Point(53, 392);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(273, 40);
            this.btnMakeReservation.TabIndex = 8;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = false;
            this.btnMakeReservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfPeople.Location = new System.Drawing.Point(242, 22);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(124, 29);
            this.txtNumberOfPeople.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of people:";
            // 
            // grpReservationDetails
            // 
            this.grpReservationDetails.Controls.Add(this.txtHourTo);
            this.grpReservationDetails.Controls.Add(this.txtMinuteTo);
            this.grpReservationDetails.Controls.Add(this.btnAMPMTo);
            this.grpReservationDetails.Controls.Add(this.label5);
            this.grpReservationDetails.Controls.Add(this.TO);
            this.grpReservationDetails.Controls.Add(this.label4);
            this.grpReservationDetails.Controls.Add(this.dntDate);
            this.grpReservationDetails.Controls.Add(this.txtNumberOfPeople);
            this.grpReservationDetails.Controls.Add(this.txtHourFrom);
            this.grpReservationDetails.Controls.Add(this.txtMinuteFrom);
            this.grpReservationDetails.Controls.Add(this.btnAMPMFrom);
            this.grpReservationDetails.Controls.Add(this.label2);
            this.grpReservationDetails.Controls.Add(this.label3);
            this.grpReservationDetails.Location = new System.Drawing.Point(15, 220);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Size = new System.Drawing.Size(376, 166);
            this.grpReservationDetails.TabIndex = 11;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation Details";
            // 
            // TO
            // 
            this.TO.AutoSize = true;
            this.TO.Location = new System.Drawing.Point(171, 131);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(33, 24);
            this.TO.TabIndex = 11;
            this.TO.Text = "To";
            // 
            // txtHourTo
            // 
            this.txtHourTo.ForeColor = System.Drawing.Color.Gray;
            this.txtHourTo.Location = new System.Drawing.Point(210, 126);
            this.txtHourTo.Name = "txtHourTo";
            this.txtHourTo.Size = new System.Drawing.Size(34, 29);
            this.txtHourTo.TabIndex = 12;
            this.txtHourTo.Text = "HH";
            this.txtHourTo.TextChanged += new System.EventHandler(this.txtHour_TextChanged_1);
            this.txtHourTo.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtHourTo.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // txtMinuteTo
            // 
            this.txtMinuteTo.ForeColor = System.Drawing.Color.Gray;
            this.txtMinuteTo.Location = new System.Drawing.Point(271, 126);
            this.txtMinuteTo.Name = "txtMinuteTo";
            this.txtMinuteTo.Size = new System.Drawing.Size(40, 29);
            this.txtMinuteTo.TabIndex = 13;
            this.txtMinuteTo.Text = "MM";
            this.txtMinuteTo.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            this.txtMinuteTo.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtMinuteTo.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // btnAMPMTo
            // 
            this.btnAMPMTo.BackColor = System.Drawing.Color.Gold;
            this.btnAMPMTo.Location = new System.Drawing.Point(317, 126);
            this.btnAMPMTo.Name = "btnAMPMTo";
            this.btnAMPMTo.Size = new System.Drawing.Size(49, 31);
            this.btnAMPMTo.TabIndex = 15;
            this.btnAMPMTo.Text = "AM";
            this.btnAMPMTo.UseVisualStyleBackColor = false;
            this.btnAMPMTo.Click += new System.EventHandler(this.btnAMPM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 444);
            this.Controls.Add(this.grpReservationDetails);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewReservation";
            this.Text = "NewReservation";
            this.Load += new System.EventHandler(this.NewReservation_Load);
            this.grpReservationDetails.ResumeLayout(false);
            this.grpReservationDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dntDate;
        private System.Windows.Forms.TextBox txtHourFrom;
        private System.Windows.Forms.TextBox txtMinuteFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAMPMFrom;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpReservationDetails;
        private System.Windows.Forms.Label TO;
        private System.Windows.Forms.TextBox txtHourTo;
        private System.Windows.Forms.TextBox txtMinuteTo;
        private System.Windows.Forms.Button btnAMPMTo;
        private System.Windows.Forms.Label label5;
    }
}