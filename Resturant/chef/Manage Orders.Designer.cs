namespace Resturant.chef
{
    partial class Manage_Orders
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
            this.btnBackManageOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackManageOrders
            // 
            this.btnBackManageOrders.BackColor = System.Drawing.Color.Tan;
            this.btnBackManageOrders.Location = new System.Drawing.Point(702, 415);
            this.btnBackManageOrders.Name = "btnBackManageOrders";
            this.btnBackManageOrders.Size = new System.Drawing.Size(75, 23);
            this.btnBackManageOrders.TabIndex = 1;
            this.btnBackManageOrders.Text = "Back >";
            this.btnBackManageOrders.UseVisualStyleBackColor = false;
            // 
            // Manage_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackManageOrders);
            this.Name = "Manage_Orders";
            this.Text = "Manage_Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackManageOrders;
    }
}