namespace Resturant.manage
{
    partial class ReservationRequest
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
            this.lstReservationRequests = new System.Windows.Forms.ListBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReservationRequests
            // 
            this.lstReservationRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lstReservationRequests.FormattingEnabled = true;
            this.lstReservationRequests.Location = new System.Drawing.Point(9, 12);
            this.lstReservationRequests.Name = "lstReservationRequests";
            this.lstReservationRequests.Size = new System.Drawing.Size(396, 160);
            this.lstReservationRequests.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Lime;
            this.btnApprove.Location = new System.Drawing.Point(13, 179);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(171, 23);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve Reservation";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancell.Location = new System.Drawing.Point(237, 178);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(171, 23);
            this.btnCancell.TabIndex = 2;
            this.btnCancell.Text = "Cancel Reservation";
            this.btnCancell.UseVisualStyleBackColor = false;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // ReservationRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(417, 214);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lstReservationRequests);
            this.Name = "ReservationRequest";
            this.Text = "ReservationRequest";
            this.Load += new System.EventHandler(this.ReservationRequest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReservationRequests;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnCancell;
    }
}