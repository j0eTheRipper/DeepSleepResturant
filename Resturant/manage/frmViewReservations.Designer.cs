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
            this.reservationDetailsFilter = new Resturant.manage.ReservationDetails();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnApproveReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.grpReservationDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AllowUserToOrderColumns = true;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(12, 217);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.Size = new System.Drawing.Size(676, 221);
            this.dgvReservations.TabIndex = 0;
            // 
            // grpReservationDetails
            // 
            this.grpReservationDetails.Controls.Add(this.chbxIncludeDate);
            this.grpReservationDetails.Controls.Add(this.reservationDetailsFilter);
            this.grpReservationDetails.Location = new System.Drawing.Point(12, 12);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Size = new System.Drawing.Size(379, 166);
            this.grpReservationDetails.TabIndex = 12;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation Details";
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
            // reservationDetailsFilter
            // 
            this.reservationDetailsFilter.Location = new System.Drawing.Point(6, 13);
            this.reservationDetailsFilter.Name = "reservationDetailsFilter";
            this.reservationDetailsFilter.Size = new System.Drawing.Size(372, 147);
            this.reservationDetailsFilter.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 184);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(176, 27);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Filter";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(482, 27);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(124, 20);
            this.txtReservationID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Reservation ID";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(613, 26);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 17;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdateReservation.Location = new System.Drawing.Point(401, 61);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(129, 23);
            this.btnUpdateReservation.TabIndex = 18;
            this.btnUpdateReservation.Text = "Update Reservation";
            this.btnUpdateReservation.UseVisualStyleBackColor = false;
            this.btnUpdateReservation.Click += new System.EventHandler(this.btnUpdateReservation_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(214, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 27);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteReservation.Location = new System.Drawing.Point(555, 61);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(133, 23);
            this.btnDeleteReservation.TabIndex = 20;
            this.btnDeleteReservation.Text = "Delete Reservation";
            this.btnDeleteReservation.UseVisualStyleBackColor = false;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(401, 155);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(278, 23);
            this.btnAddReservation.TabIndex = 21;
            this.btnAddReservation.Text = "Reserve For Customer";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnApproveReservation
            // 
            this.btnApproveReservation.Location = new System.Drawing.Point(401, 187);
            this.btnApproveReservation.Name = "btnApproveReservation";
            this.btnApproveReservation.Size = new System.Drawing.Size(278, 23);
            this.btnApproveReservation.TabIndex = 22;
            this.btnApproveReservation.Text = "Approve reservations";
            this.btnApproveReservation.UseVisualStyleBackColor = true;
            this.btnApproveReservation.Click += new System.EventHandler(this.btnApproveReservation_Click);
            // 
            // frmViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(691, 443);
            this.Controls.Add(this.btnApproveReservation);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdateReservation);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpReservationDetails);
            this.Controls.Add(this.dgvReservations);
            this.Name = "frmViewReservations";
            this.Text = "frmViewReservations";
            this.Load += new System.EventHandler(this.frmViewReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.grpReservationDetails.ResumeLayout(false);
            this.grpReservationDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.GroupBox grpReservationDetails;
        private ReservationDetails reservationDetailsFilter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chbxIncludeDate;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnApproveReservation;
    }
}