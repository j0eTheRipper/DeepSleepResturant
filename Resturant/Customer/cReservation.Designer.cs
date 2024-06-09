namespace Resturant.Customer
{
    partial class cReservation
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
            this.btnNewReservation = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblReservationS = new System.Windows.Forms.Label();
            this.lablReS = new System.Windows.Forms.Label();
            this.reservationDetails1 = new Resturant.manage.ReservationDetails();
            this.SuspendLayout();
            // 
            // btnNewReservation
            // 
            this.btnNewReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnNewReservation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewReservation.FlatAppearance.BorderSize = 4;
            this.btnNewReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReservation.ForeColor = System.Drawing.Color.White;
            this.btnNewReservation.Location = new System.Drawing.Point(13, 229);
            this.btnNewReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewReservation.Name = "btnNewReservation";
            this.btnNewReservation.Size = new System.Drawing.Size(197, 41);
            this.btnNewReservation.TabIndex = 19;
            this.btnNewReservation.Text = "New Reservation";
            this.btnNewReservation.UseVisualStyleBackColor = false;
            this.btnNewReservation.Click += new System.EventHandler(this.btnNewReservation_Click);
            // 
            // lblReservationS
            // 
            this.lblReservationS.AutoSize = true;
            this.lblReservationS.ForeColor = System.Drawing.Color.White;
            this.lblReservationS.Location = new System.Drawing.Point(339, 229);
            this.lblReservationS.Name = "lblReservationS";
            this.lblReservationS.Size = new System.Drawing.Size(120, 16);
            this.lblReservationS.TabIndex = 21;
            this.lblReservationS.Text = "Reservation Status";
            this.lblReservationS.Click += new System.EventHandler(this.label1_Click);
            // 
            // lablReS
            // 
            this.lablReS.AutoSize = true;
            this.lablReS.ForeColor = System.Drawing.Color.White;
            this.lablReS.Location = new System.Drawing.Point(339, 254);
            this.lablReS.Name = "lablReS";
            this.lablReS.Size = new System.Drawing.Size(170, 16);
            this.lablReS.TabIndex = 22;
            this.lablReS.Text = "Your Reservation Status is: \r\n";
            // 
            // reservationDetails1
            // 
            this.reservationDetails1.BackColor = System.Drawing.Color.White;
            this.reservationDetails1.Location = new System.Drawing.Point(13, 27);
            this.reservationDetails1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reservationDetails1.Name = "reservationDetails1";
            this.reservationDetails1.Size = new System.Drawing.Size(496, 182);
            this.reservationDetails1.TabIndex = 20;
            this.reservationDetails1.Load += new System.EventHandler(this.reservationDetails1_Load);
            // 
            // cReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lablReS);
            this.Controls.Add(this.lblReservationS);
            this.Controls.Add(this.reservationDetails1);
            this.Controls.Add(this.btnNewReservation);
            this.Name = "cReservation";
            this.Text = "cReservation";
            this.Load += new System.EventHandler(this.cReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewReservation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private manage.ReservationDetails reservationDetails1;
        private System.Windows.Forms.Label lblReservationS;
        private System.Windows.Forms.Label lablReS;
    }
}