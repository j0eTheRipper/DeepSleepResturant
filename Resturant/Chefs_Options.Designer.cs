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
            this.Add1chef.Location = new System.Drawing.Point(282, 112);
            this.Add1chef.Name = "Add1chef";
            this.Add1chef.Size = new System.Drawing.Size(226, 66);
            this.Add1chef.TabIndex = 0;
            this.Add1chef.Text = "Add";
            this.Add1chef.UseVisualStyleBackColor = false;
            // 
            // Edit1chef
            // 
            this.Edit1chef.BackColor = System.Drawing.Color.Tan;
            this.Edit1chef.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit1chef.Location = new System.Drawing.Point(282, 218);
            this.Edit1chef.Name = "Edit1chef";
            this.Edit1chef.Size = new System.Drawing.Size(226, 71);
            this.Edit1chef.TabIndex = 1;
            this.Edit1chef.Text = "Edit";
            this.Edit1chef.UseVisualStyleBackColor = false;
            // 
            // Delete1chef
            // 
            this.Delete1chef.BackColor = System.Drawing.Color.Tan;
            this.Delete1chef.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete1chef.Location = new System.Drawing.Point(282, 334);
            this.Delete1chef.Name = "Delete1chef";
            this.Delete1chef.Size = new System.Drawing.Size(226, 70);
            this.Delete1chef.TabIndex = 2;
            this.Delete1chef.Text = "Delete";
            this.Delete1chef.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Managing chefs";
            // 
            // Chefs_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete1chef);
            this.Controls.Add(this.Edit1chef);
            this.Controls.Add(this.Add1chef);
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