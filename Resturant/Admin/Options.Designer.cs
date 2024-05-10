namespace Resturant.Admin
{
    partial class Options
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.Color.Tan;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox3.Location = new System.Drawing.Point(15, 245);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(283, 65);
            this.TextBox3.TabIndex = 13;
            this.TextBox3.Text = "Add Users";
            this.TextBox3.UseVisualStyleBackColor = false;
            this.TextBox3.Click += new System.EventHandler(this.TextBox3_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.Tan;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox2.Location = new System.Drawing.Point(372, 241);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(283, 71);
            this.TextBox2.TabIndex = 14;
            this.TextBox2.Text = "Delete Users";
            this.TextBox2.UseVisualStyleBackColor = false;
            this.TextBox2.Click += new System.EventHandler(this.TextBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(733, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 71);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update Own Profile";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 53);
            this.label1.TabIndex = 16;
            this.label1.Text = "AdminMainPage";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1083, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TextBox3;
        private System.Windows.Forms.Button TextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}