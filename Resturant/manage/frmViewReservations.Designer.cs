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
            this.reservationDetails1 = new Resturant.manage.ReservationDetails();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chbxIncludeDate = new System.Windows.Forms.CheckBox();
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
            this.grpReservationDetails.Controls.Add(this.chbxIncludeDate);
            this.grpReservationDetails.Controls.Add(this.reservationDetails1);
            this.grpReservationDetails.Location = new System.Drawing.Point(12, 12);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Size = new System.Drawing.Size(379, 166);
            this.grpReservationDetails.TabIndex = 12;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation Details";
            // 
            // reservationDetails1
            // 
            this.reservationDetails1.Location = new System.Drawing.Point(6, 13);
            this.reservationDetails1.Name = "reservationDetails1";
            this.reservationDetails1.Size = new System.Drawing.Size(372, 147);
            this.reservationDetails1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(396, 25);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(392, 147);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Filter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chbxIncludeDate
            // 
            this.chbxIncludeDate.AutoSize = true;
            this.chbxIncludeDate.Location = new System.Drawing.Point(149, 55);
            this.chbxIncludeDate.Name = "chbxIncludeDate";
            this.chbxIncludeDate.Size = new System.Drawing.Size(87, 17);
            this.chbxIncludeDate.TabIndex = 1;
            this.chbxIncludeDate.Text = "Include Date";
            this.chbxIncludeDate.UseVisualStyleBackColor = true;
            // 
            // frmViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
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
        private ReservationDetails reservationDetails1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chbxIncludeDate;
    }
}