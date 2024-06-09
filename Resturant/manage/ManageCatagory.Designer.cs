namespace Resturant.manage
{
    partial class ManageCatagory
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
            this.txtNewCatagory = new System.Windows.Forms.TextBox();
            this.btnAddCatagory = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewCatagory
            // 
            this.txtNewCatagory.Location = new System.Drawing.Point(13, 45);
            this.txtNewCatagory.Name = "txtNewCatagory";
            this.txtNewCatagory.Size = new System.Drawing.Size(171, 20);
            this.txtNewCatagory.TabIndex = 0;
            // 
            // btnAddCatagory
            // 
            this.btnAddCatagory.Location = new System.Drawing.Point(12, 71);
            this.btnAddCatagory.Name = "btnAddCatagory";
            this.btnAddCatagory.Size = new System.Drawing.Size(172, 23);
            this.btnAddCatagory.TabIndex = 1;
            this.btnAddCatagory.Text = "Add";
            this.btnAddCatagory.UseVisualStyleBackColor = true;
            this.btnAddCatagory.Click += new System.EventHandler(this.btnAddCatagory_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(19, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(162, 24);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Add new catagory";
            // 
            // AddCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 103);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAddCatagory);
            this.Controls.Add(this.txtNewCatagory);
            this.Name = "AddCatagory";
            this.Text = "AddCatagory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewCatagory;
        private System.Windows.Forms.Button btnAddCatagory;
        private System.Windows.Forms.Label lblStatus;
    }
}