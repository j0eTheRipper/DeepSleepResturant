namespace Resturant.manage
{
    partial class ReservationDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHourTo = new System.Windows.Forms.TextBox();
            this.txtMinuteTo = new System.Windows.Forms.TextBox();
            this.btnAMPMTo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dntDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.txtHourFrom = new System.Windows.Forms.TextBox();
            this.txtMinuteFrom = new System.Windows.Forms.TextBox();
            this.btnAMPMFrom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHourTo
            // 
            this.txtHourTo.ForeColor = System.Drawing.Color.Gray;
            this.txtHourTo.Location = new System.Drawing.Point(207, 111);
            this.txtHourTo.Name = "txtHourTo";
            this.txtHourTo.Size = new System.Drawing.Size(44, 20);
            this.txtHourTo.TabIndex = 25;
            this.txtHourTo.Text = "HH";
            this.txtHourTo.TextChanged += new System.EventHandler(this.txtHour_TextChanged_1);
            this.txtHourTo.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtHourTo.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // txtMinuteTo
            // 
            this.txtMinuteTo.ForeColor = System.Drawing.Color.Gray;
            this.txtMinuteTo.Location = new System.Drawing.Point(268, 111);
            this.txtMinuteTo.Name = "txtMinuteTo";
            this.txtMinuteTo.Size = new System.Drawing.Size(40, 20);
            this.txtMinuteTo.TabIndex = 26;
            this.txtMinuteTo.Text = "MM";
            this.txtMinuteTo.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            this.txtMinuteTo.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtMinuteTo.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // btnAMPMTo
            // 
            this.btnAMPMTo.BackColor = System.Drawing.Color.Gold;
            this.btnAMPMTo.Location = new System.Drawing.Point(314, 111);
            this.btnAMPMTo.Name = "btnAMPMTo";
            this.btnAMPMTo.Size = new System.Drawing.Size(49, 31);
            this.btnAMPMTo.TabIndex = 28;
            this.btnAMPMTo.Text = "AM";
            this.btnAMPMTo.UseVisualStyleBackColor = false;
            this.btnAMPMTo.Click += new System.EventHandler(this.btnAMPM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = ":";
            // 
            // TO
            // 
            this.TO.AutoSize = true;
            this.TO.Location = new System.Drawing.Point(168, 116);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(20, 13);
            this.TO.TabIndex = 24;
            this.TO.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Number of people:";
            // 
            // dntDate
            // 
            this.dntDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dntDate.Location = new System.Drawing.Point(7, 78);
            this.dntDate.MinDate = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            this.dntDate.Name = "dntDate";
            this.dntDate.Size = new System.Drawing.Size(356, 20);
            this.dntDate.TabIndex = 16;
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfPeople.Location = new System.Drawing.Point(224, 10);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(124, 20);
            this.txtNumberOfPeople.TabIndex = 22;
            // 
            // txtHourFrom
            // 
            this.txtHourFrom.ForeColor = System.Drawing.Color.Gray;
            this.txtHourFrom.Location = new System.Drawing.Point(3, 111);
            this.txtHourFrom.Name = "txtHourFrom";
            this.txtHourFrom.Size = new System.Drawing.Size(44, 20);
            this.txtHourFrom.TabIndex = 17;
            this.txtHourFrom.Text = "HH";
            this.txtHourFrom.TextChanged += new System.EventHandler(this.txtHour_TextChanged_1);
            this.txtHourFrom.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtHourFrom.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // txtMinuteFrom
            // 
            this.txtMinuteFrom.ForeColor = System.Drawing.Color.Gray;
            this.txtMinuteFrom.Location = new System.Drawing.Point(68, 111);
            this.txtMinuteFrom.Name = "txtMinuteFrom";
            this.txtMinuteFrom.Size = new System.Drawing.Size(40, 20);
            this.txtMinuteFrom.TabIndex = 18;
            this.txtMinuteFrom.Text = "MM";
            this.txtMinuteFrom.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            this.txtMinuteFrom.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtMinuteFrom.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // btnAMPMFrom
            // 
            this.btnAMPMFrom.BackColor = System.Drawing.Color.Gold;
            this.btnAMPMFrom.Location = new System.Drawing.Point(114, 111);
            this.btnAMPMFrom.Name = "btnAMPMFrom";
            this.btnAMPMFrom.Size = new System.Drawing.Size(49, 31);
            this.btnAMPMFrom.TabIndex = 21;
            this.btnAMPMFrom.Text = "AM";
            this.btnAMPMFrom.UseVisualStyleBackColor = false;
            this.btnAMPMFrom.Click += new System.EventHandler(this.btnAMPM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "date and time of reservation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = ":";
            // 
            // ReservationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHourTo);
            this.Controls.Add(this.txtMinuteTo);
            this.Controls.Add(this.btnAMPMTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dntDate);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.txtHourFrom);
            this.Controls.Add(this.txtMinuteFrom);
            this.Controls.Add(this.btnAMPMFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "ReservationDetails";
            this.Size = new System.Drawing.Size(372, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHourTo;
        private System.Windows.Forms.TextBox txtMinuteTo;
        private System.Windows.Forms.Button btnAMPMTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dntDate;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.TextBox txtHourFrom;
        private System.Windows.Forms.TextBox txtMinuteFrom;
        private System.Windows.Forms.Button btnAMPMFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
