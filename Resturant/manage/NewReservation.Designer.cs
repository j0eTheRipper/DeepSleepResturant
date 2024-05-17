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
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAMPM = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 24;
            this.lstCustomers.Location = new System.Drawing.Point(15, 39);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(263, 172);
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
            this.dntDate.Location = new System.Drawing.Point(35, 305);
            this.dntDate.MinDate = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            this.dntDate.Name = "dntDate";
            this.dntDate.Size = new System.Drawing.Size(228, 29);
            this.dntDate.TabIndex = 2;
            // 
            // txtHour
            // 
            this.txtHour.ForeColor = System.Drawing.Color.Gray;
            this.txtHour.Location = new System.Drawing.Point(15, 344);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(84, 29);
            this.txtHour.TabIndex = 3;
            this.txtHour.Text = "HH";
            this.txtHour.TextChanged += new System.EventHandler(this.txtHour_TextChanged_1);
            this.txtHour.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtHour.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // txtMinute
            // 
            this.txtMinute.ForeColor = System.Drawing.Color.Gray;
            this.txtMinute.Location = new System.Drawing.Point(126, 344);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(80, 29);
            this.txtMinute.TabIndex = 4;
            this.txtMinute.Text = "MM";
            this.txtMinute.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            this.txtMinute.Enter += new System.EventHandler(this.txtBoxEnter);
            this.txtMinute.Leave += new System.EventHandler(this.txtBoxLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "date and time of reservation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // btnAMPM
            // 
            this.btnAMPM.BackColor = System.Drawing.Color.Gold;
            this.btnAMPM.Location = new System.Drawing.Point(212, 342);
            this.btnAMPM.Name = "btnAMPM";
            this.btnAMPM.Size = new System.Drawing.Size(76, 31);
            this.btnAMPM.TabIndex = 7;
            this.btnAMPM.Text = "AM";
            this.btnAMPM.UseVisualStyleBackColor = false;
            this.btnAMPM.Click += new System.EventHandler(this.btnAMPM_Click);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.Color.DarkGray;
            this.btnMakeReservation.ForeColor = System.Drawing.Color.Black;
            this.btnMakeReservation.Location = new System.Drawing.Point(15, 392);
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
            this.txtNumberOfPeople.Location = new System.Drawing.Point(185, 237);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(103, 29);
            this.txtNumberOfPeople.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of people:";
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.btnAMPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.dntDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewReservation";
            this.Text = "NewReservation";
            this.Load += new System.EventHandler(this.NewReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dntDate;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAMPM;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.Label label4;
    }
}