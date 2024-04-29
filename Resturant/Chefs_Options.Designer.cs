namespace Resturant
{
    partial class Chefs_Options
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
            this.Add1chef = new System.Windows.Forms.Button();
            this.Edit1chef = new System.Windows.Forms.Button();
            this.Delete1chef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add1chef
            // 
            this.Add1chef.BackColor = System.Drawing.Color.Tan;
            this.Add1chef.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add1chef.Location = new System.Drawing.Point(13, 271);
            this.Add1chef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add1chef.Name = "Add1chef";
            this.Add1chef.Size = new System.Drawing.Size(301, 81);
            this.Add1chef.TabIndex = 0;
            this.Add1chef.Text = "Add";
            this.Add1chef.UseVisualStyleBackColor = false;
            this.Add1chef.Click += new System.EventHandler(this.Add1chef_Click);
            // 
            // Edit1chef
            // 
            this.Edit1chef.BackColor = System.Drawing.Color.Tan;
            this.Edit1chef.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit1chef.Location = new System.Drawing.Point(376, 268);
            this.Edit1chef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit1chef.Name = "Edit1chef";
            this.Edit1chef.Size = new System.Drawing.Size(301, 87);
            this.Edit1chef.TabIndex = 1;
            this.Edit1chef.Text = "Edit";
            this.Edit1chef.UseVisualStyleBackColor = false;
            this.Edit1chef.Click += new System.EventHandler(this.Edit1chef_Click);
            // 
            // Delete1chef
            // 
            this.Delete1chef.BackColor = System.Drawing.Color.Tan;
            this.Delete1chef.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete1chef.Location = new System.Drawing.Point(753, 271);
            this.Delete1chef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete1chef.Name = "Delete1chef";
            this.Delete1chef.Size = new System.Drawing.Size(301, 86);
            this.Delete1chef.TabIndex = 2;
            this.Delete1chef.Text = "Delete";
            this.Delete1chef.UseVisualStyleBackColor = false;
            this.Delete1chef.Click += new System.EventHandler(this.Delete1chef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Managing chefs";
            // 
            // Chefs_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete1chef);
            this.Controls.Add(this.Edit1chef);
            this.Controls.Add(this.Add1chef);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Chefs_Options";
            this.Text = "Chefs_Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add1chef;
        private System.Windows.Forms.Button Edit1chef;
        private System.Windows.Forms.Button Delete1chef;
        private System.Windows.Forms.Label label1;
    }
}