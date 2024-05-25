namespace Resturant.Customer
{
    partial class cFeedBack
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
            this.CustomerFeedback = new System.Windows.Forms.Label();
            this.textFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerFeedback
            // 
            this.CustomerFeedback.AutoSize = true;
            this.CustomerFeedback.Location = new System.Drawing.Point(12, 21);
            this.CustomerFeedback.Name = "CustomerFeedback";
            this.CustomerFeedback.Size = new System.Drawing.Size(134, 16);
            this.CustomerFeedback.TabIndex = 0;
            this.CustomerFeedback.Text = "Write Your Feedback";
            // 
            // textFeedback
            // 
            this.textFeedback.Location = new System.Drawing.Point(12, 49);
            this.textFeedback.Multiline = true;
            this.textFeedback.Name = "textFeedback";
            this.textFeedback.Size = new System.Drawing.Size(300, 100);
            this.textFeedback.TabIndex = 1;
            this.textFeedback.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Location = new System.Drawing.Point(12, 263);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(60, 23);
            this.btnSubmit1.TabIndex = 2;
            this.btnSubmit1.Text = "Submit Your Feedback ";
            this.btnSubmit1.UseVisualStyleBackColor = true;
            this.btnSubmit1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(12, 171);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(80, 16);
            this.CustomerID.TabIndex = 3;
            this.CustomerID.Text = "Customer ID";
            this.CustomerID.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(12, 212);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerID.TabIndex = 4;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.CustomerFeedback);
            this.panel1.Controls.Add(this.btnSubmit1);
            this.panel1.Controls.Add(this.CustomerID);
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.textFeedback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 450);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "cFeedBack";
            this.Text = "cFeedBack";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomerFeedback;
        private System.Windows.Forms.TextBox textFeedback;
        private System.Windows.Forms.Button btnSubmit1;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Panel panel1;
    }
}