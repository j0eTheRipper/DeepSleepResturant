namespace Resturant.Customer
{
    partial class cOrderFood
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
            this.btnAddthisOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddthisOrder
            // 
            this.btnAddthisOrder.Location = new System.Drawing.Point(426, 206);
            this.btnAddthisOrder.Name = "btnAddthisOrder";
            this.btnAddthisOrder.Size = new System.Drawing.Size(141, 23);
            this.btnAddthisOrder.TabIndex = 0;
            this.btnAddthisOrder.Text = "Add This Order";
            this.btnAddthisOrder.UseVisualStyleBackColor = true;
            // 
            // cOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(903, 502);
            this.Controls.Add(this.btnAddthisOrder);
            this.Name = "cOrderFood";
            this.Text = "cOrderFood";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddthisOrder;
    }
}