namespace Resturant.manage
{
    partial class MenuFilter
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
            this.cmbCatagoryFilter = new System.Windows.Forms.ComboBox();
            this.lstMenuItems = new System.Windows.Forms.ListBox();
            this.picMenuImage = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCatagoryFilter
            // 
            this.cmbCatagoryFilter.FormattingEnabled = true;
            this.cmbCatagoryFilter.Items.AddRange(new object[] {
            "Show All Items"});
            this.cmbCatagoryFilter.Location = new System.Drawing.Point(10, 218);
            this.cmbCatagoryFilter.Name = "cmbCatagoryFilter";
            this.cmbCatagoryFilter.Size = new System.Drawing.Size(144, 21);
            this.cmbCatagoryFilter.TabIndex = 8;
            this.cmbCatagoryFilter.Text = "Show All Items";
            this.cmbCatagoryFilter.SelectedIndexChanged += new System.EventHandler(this.cmbCatagoryFilter_SelectedIndexChanged);
            // 
            // lstMenuItems
            // 
            this.lstMenuItems.FormattingEnabled = true;
            this.lstMenuItems.Location = new System.Drawing.Point(10, 13);
            this.lstMenuItems.Name = "lstMenuItems";
            this.lstMenuItems.Size = new System.Drawing.Size(144, 199);
            this.lstMenuItems.TabIndex = 5;
            this.lstMenuItems.SelectedIndexChanged += new System.EventHandler(this.lstMenuItems_SelectedIndexChanged);
            // 
            // picMenuImage
            // 
            this.picMenuImage.Location = new System.Drawing.Point(161, 13);
            this.picMenuImage.Name = "picMenuImage";
            this.picMenuImage.Size = new System.Drawing.Size(308, 199);
            this.picMenuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuImage.TabIndex = 6;
            this.picMenuImage.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(160, 221);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(403, 218);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 11;
            // 
            // MenuFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cmbCatagoryFilter);
            this.Controls.Add(this.picMenuImage);
            this.Controls.Add(this.lstMenuItems);
            this.Name = "MenuFilter";
            this.Size = new System.Drawing.Size(473, 249);
            this.Load += new System.EventHandler(this.MenuFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCatagoryFilter;
        private System.Windows.Forms.PictureBox picMenuImage;
        private System.Windows.Forms.ListBox lstMenuItems;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
    }
}
