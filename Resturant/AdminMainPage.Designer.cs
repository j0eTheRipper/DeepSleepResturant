namespace Resturant
{
    partial class AdminMainPage
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
            this.TextBox3 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.Color.Tan;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox3.Location = new System.Drawing.Point(248, 139);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(283, 65);
            this.TextBox3.TabIndex = 12;
            this.TextBox3.Text = "Manage Chefs";
            this.TextBox3.UseVisualStyleBackColor = false;
            this.TextBox3.Click += new System.EventHandler(this.TextBox3_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.Tan;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox2.Location = new System.Drawing.Point(12, 260);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(283, 71);
            this.TextBox2.TabIndex = 11;
            this.TextBox2.Text = "Manage Customers";
            this.TextBox2.UseVisualStyleBackColor = false;
            this.TextBox2.Click += new System.EventHandler(this.TextBox2_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Tan;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox1.Location = new System.Drawing.Point(505, 266);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(283, 65);
            this.TextBox1.TabIndex = 10;
            this.TextBox1.Text = "Manage Managers";
            this.TextBox1.UseVisualStyleBackColor = false;
            this.TextBox1.Click += new System.EventHandler(this.TextBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 9;
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMainPage";
            this.Text = "AdminMainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TextBox3;
        private System.Windows.Forms.Button TextBox2;
        private System.Windows.Forms.Button TextBox1;
        private System.Windows.Forms.Label label3;
    }
}