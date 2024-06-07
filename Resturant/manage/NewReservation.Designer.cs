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
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.reservationDetails1 = new Resturant.manage.ReservationDetails();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(10, 21);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(363, 95);
            this.lstCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer to reserve";
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.Color.DarkGray;
            this.btnMakeReservation.ForeColor = System.Drawing.Color.Black;
            this.btnMakeReservation.Location = new System.Drawing.Point(116, 293);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(149, 22);
            this.btnMakeReservation.TabIndex = 8;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = false;
            this.btnMakeReservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservationDetails1
            // 
            this.reservationDetails1.Location = new System.Drawing.Point(10, 122);
            this.reservationDetails1.Name = "reservationDetails1";
            this.reservationDetails1.Size = new System.Drawing.Size(372, 148);
            this.reservationDetails1.TabIndex = 9;
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 326);
            this.Controls.Add(this.reservationDetails1);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustomers);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "NewReservation";
            this.Text = "NewReservation";
            this.Load += new System.EventHandler(this.NewReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeReservation;
        private manage.ReservationDetails reservationDetails1;
    }
}