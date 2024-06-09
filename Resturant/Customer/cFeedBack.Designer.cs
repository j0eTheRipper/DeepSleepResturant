namespace Resturant.Customer
{
    partial class cFeedback
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFeedBack = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVeryUnsatisfied = new System.Windows.Forms.RadioButton();
            this.rdoUnsatisfied = new System.Windows.Forms.RadioButton();
            this.rdoNeutral = new System.Windows.Forms.RadioButton();
            this.rdoSatisfied = new System.Windows.Forms.RadioButton();
            this.rdoVerySatisfied = new System.Windows.Forms.RadioButton();
            this.txtService = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Of Service";
            // 
            // txtFeedBack
            // 
            this.txtFeedBack.Location = new System.Drawing.Point(291, 32);
            this.txtFeedBack.Name = "txtFeedBack";
            this.txtFeedBack.Size = new System.Drawing.Size(100, 22);
            this.txtFeedBack.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "How Satisified are you with our service?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVeryUnsatisfied);
            this.groupBox1.Controls.Add(this.rdoUnsatisfied);
            this.groupBox1.Controls.Add(this.rdoNeutral);
            this.groupBox1.Controls.Add(this.rdoSatisfied);
            this.groupBox1.Controls.Add(this.rdoVerySatisfied);
            this.groupBox1.Location = new System.Drawing.Point(52, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 43);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoVeryUnsatisfied
            // 
            this.rdoVeryUnsatisfied.AutoSize = true;
            this.rdoVeryUnsatisfied.Location = new System.Drawing.Point(447, 17);
            this.rdoVeryUnsatisfied.Name = "rdoVeryUnsatisfied";
            this.rdoVeryUnsatisfied.Size = new System.Drawing.Size(129, 20);
            this.rdoVeryUnsatisfied.TabIndex = 10;
            this.rdoVeryUnsatisfied.TabStop = true;
            this.rdoVeryUnsatisfied.Text = "Very Unsatisified";
            this.rdoVeryUnsatisfied.UseVisualStyleBackColor = true;
            // 
            // rdoUnsatisfied
            // 
            this.rdoUnsatisfied.AutoSize = true;
            this.rdoUnsatisfied.Location = new System.Drawing.Point(326, 17);
            this.rdoUnsatisfied.Name = "rdoUnsatisfied";
            this.rdoUnsatisfied.Size = new System.Drawing.Size(90, 20);
            this.rdoUnsatisfied.TabIndex = 9;
            this.rdoUnsatisfied.TabStop = true;
            this.rdoUnsatisfied.Text = "Unsatisifid";
            this.rdoUnsatisfied.UseVisualStyleBackColor = true;
            // 
            // rdoNeutral
            // 
            this.rdoNeutral.AutoSize = true;
            this.rdoNeutral.Location = new System.Drawing.Point(226, 17);
            this.rdoNeutral.Name = "rdoNeutral";
            this.rdoNeutral.Size = new System.Drawing.Size(71, 20);
            this.rdoNeutral.TabIndex = 8;
            this.rdoNeutral.TabStop = true;
            this.rdoNeutral.Text = "Neutral";
            this.rdoNeutral.UseVisualStyleBackColor = true;
            // 
            // rdoSatisfied
            // 
            this.rdoSatisfied.AutoSize = true;
            this.rdoSatisfied.Location = new System.Drawing.Point(126, 17);
            this.rdoSatisfied.Name = "rdoSatisfied";
            this.rdoSatisfied.Size = new System.Drawing.Size(83, 20);
            this.rdoSatisfied.TabIndex = 7;
            this.rdoSatisfied.TabStop = true;
            this.rdoSatisfied.Text = "Satisified";
            this.rdoSatisfied.UseVisualStyleBackColor = true;
            // 
            // rdoVerySatisfied
            // 
            this.rdoVerySatisfied.AutoSize = true;
            this.rdoVerySatisfied.Location = new System.Drawing.Point(6, 17);
            this.rdoVerySatisfied.Name = "rdoVerySatisfied";
            this.rdoVerySatisfied.Size = new System.Drawing.Size(114, 20);
            this.rdoVerySatisfied.TabIndex = 6;
            this.rdoVerySatisfied.TabStop = true;
            this.rdoVerySatisfied.Text = "Very Satisified";
            this.rdoVerySatisfied.UseVisualStyleBackColor = true;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(52, 153);
            this.txtService.Multiline = true;
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(591, 86);
            this.txtService.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFeedBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cFeedback";
            this.Text = "cFeedBack";
            this.Load += new System.EventHandler(this.cFeedback_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFeedBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVeryUnsatisfied;
        private System.Windows.Forms.RadioButton rdoUnsatisfied;
        private System.Windows.Forms.RadioButton rdoNeutral;
        private System.Windows.Forms.RadioButton rdoSatisfied;
        private System.Windows.Forms.RadioButton rdoVerySatisfied;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}