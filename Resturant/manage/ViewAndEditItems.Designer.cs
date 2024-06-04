namespace Resturant.manage
{
    partial class ViewAndEditItems
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.menuFilter1 = new Resturant.manage.MenuFilter();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(13, 415);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(144, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Items";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // menuFilter1
            // 
            this.menuFilter1.Location = new System.Drawing.Point(13, 13);
            this.menuFilter1.Name = "menuFilter1";
            this.menuFilter1.Size = new System.Drawing.Size(458, 249);
            this.menuFilter1.TabIndex = 3;
            // 
            // ViewAndEditItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.menuFilter1);
            this.Controls.Add(this.btnAddItem);
            this.Name = "ViewAndEditItems";
            this.Text = "ViewAndEditItems";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddItem;
        private MenuFilter menuFilter1;
    }
}