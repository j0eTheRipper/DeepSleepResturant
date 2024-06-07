namespace Resturant
{
    partial class ManagerMainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lnkMenu = new System.Windows.Forms.LinkLabel();
            this.lnkReservationRequest = new System.Windows.Forms.LinkLabel();
            this.lnkReservationReport = new System.Windows.Forms.LinkLabel();
            this.lnkReserveForCustomer = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Home Page";
            // 
            // lnkMenu
            // 
            this.lnkMenu.AutoSize = true;
            this.lnkMenu.Location = new System.Drawing.Point(197, 339);
            this.lnkMenu.Name = "lnkMenu";
            this.lnkMenu.Size = new System.Drawing.Size(150, 25);
            this.lnkMenu.TabIndex = 3;
            this.lnkMenu.TabStop = true;
            this.lnkMenu.Text = "Manage Menu";
            this.lnkMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMenu_LinkClicked);
            // 
            // lnkReservationRequest
            // 
            this.lnkReservationRequest.AutoSize = true;
            this.lnkReservationRequest.Location = new System.Drawing.Point(197, 240);
            this.lnkReservationRequest.Name = "lnkReservationRequest";
            this.lnkReservationRequest.Size = new System.Drawing.Size(292, 25);
            this.lnkReservationRequest.TabIndex = 2;
            this.lnkReservationRequest.TabStop = true;
            this.lnkReservationRequest.Text = "Process reservation requests";
            this.lnkReservationRequest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReservation_LinkClicked);
            // 
            // lnkReservationReport
            // 
            this.lnkReservationReport.AutoSize = true;
            this.lnkReservationReport.Location = new System.Drawing.Point(197, 187);
            this.lnkReservationReport.Name = "lnkReservationReport";
            this.lnkReservationReport.Size = new System.Drawing.Size(249, 25);
            this.lnkReservationReport.TabIndex = 1;
            this.lnkReservationReport.TabStop = true;
            this.lnkReservationReport.Text = "View Reservation Report";
            this.lnkReservationReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReservationReport_LinkClicked);
            // 
            // lnkReserveForCustomer
            // 
            this.lnkReserveForCustomer.AutoSize = true;
            this.lnkReserveForCustomer.Location = new System.Drawing.Point(197, 293);
            this.lnkReserveForCustomer.Name = "lnkReserveForCustomer";
            this.lnkReserveForCustomer.Size = new System.Drawing.Size(217, 25);
            this.lnkReserveForCustomer.TabIndex = 4;
            this.lnkReserveForCustomer.TabStop = true;
            this.lnkReserveForCustomer.Text = "Reserve for customer";
            this.lnkReserveForCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReserveForCustomer_LinkClicked);
            // 
            // ManagerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 468);
            this.Controls.Add(this.lnkReserveForCustomer);
            this.Controls.Add(this.lnkReservationReport);
            this.Controls.Add(this.lnkReservationRequest);
            this.Controls.Add(this.lnkMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManagerMainPage";
            this.Text = "ManagerMainPage";
            this.Load += new System.EventHandler(this.ManagerMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkMenu;
        private System.Windows.Forms.LinkLabel lnkReservationRequest;
        private System.Windows.Forms.LinkLabel lnkReservationReport;
        private System.Windows.Forms.LinkLabel lnkReserveForCustomer;
    }
}