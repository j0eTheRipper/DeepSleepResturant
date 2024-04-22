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
            this.TextBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.TextBox3.Location = new System.Drawing.Point(259, 301);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(282, 51);
            this.TextBox3.TabIndex = 12;
            this.TextBox3.Text = "Manage Managers";
            this.TextBox3.UseVisualStyleBackColor = true;
            // 
            // TextBox2
            // 
            this.TextBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.TextBox2.Location = new System.Drawing.Point(259, 196);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(282, 55);
            this.TextBox2.TabIndex = 11;
            this.TextBox2.Text = "Manage Chefs";
            this.TextBox2.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            this.TextBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.TextBox1.Location = new System.Drawing.Point(259, 99);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(282, 53);
            this.TextBox1.TabIndex = 10;
            this.TextBox1.Text = "manage customers";
            this.TextBox1.UseVisualStyleBackColor = true;
            this.TextBox1.Click += new System.EventHandler(this.TextBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 9;
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label3);
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