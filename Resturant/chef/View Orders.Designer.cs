namespace Resturant.chef
{
    partial class View_Orders
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
            this.lblViewOrderPage = new System.Windows.Forms.Label();
            this.btnBackOrd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblCustOrder = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblViewOrderPage
            // 
            this.lblViewOrderPage.AutoSize = true;
            this.lblViewOrderPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrderPage.Location = new System.Drawing.Point(333, 18);
            this.lblViewOrderPage.Name = "lblViewOrderPage";
            this.lblViewOrderPage.Size = new System.Drawing.Size(155, 31);
            this.lblViewOrderPage.TabIndex = 19;
            this.lblViewOrderPage.Text = "View Orders";
            // 
            // btnBackOrd
            // 
            this.btnBackOrd.BackColor = System.Drawing.Color.Tan;
            this.btnBackOrd.Location = new System.Drawing.Point(700, 400);
            this.btnBackOrd.Name = "btnBackOrd";
            this.btnBackOrd.Size = new System.Drawing.Size(75, 23);
            this.btnBackOrd.TabIndex = 18;
            this.btnBackOrd.Text = "Back>";
            this.btnBackOrd.UseVisualStyleBackColor = false;
            this.btnBackOrd.Click += new System.EventHandler(this.btnBackOrd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "order number will show her";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "order will show here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "customer name will show here";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(35, 407);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(92, 16);
            this.lblOrderNo.TabIndex = 14;
            this.lblOrderNo.Text = "Order Number";
            // 
            // lblCustOrder
            // 
            this.lblCustOrder.AutoSize = true;
            this.lblCustOrder.Location = new System.Drawing.Point(35, 358);
            this.lblCustOrder.Name = "lblCustOrder";
            this.lblCustOrder.Size = new System.Drawing.Size(111, 16);
            this.lblCustOrder.TabIndex = 13;
            this.lblCustOrder.Text = "Customer\'s Order";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(35, 312);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(104, 16);
            this.lblCustName.TabIndex = 12;
            this.lblCustName.Text = "Customer Name";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Tan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 132);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Tan;
            this.btnView.Location = new System.Drawing.Point(567, 382);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(85, 50);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View Order";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // View_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblViewOrderPage);
            this.Controls.Add(this.btnBackOrd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.lblCustOrder);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnView);
            this.Name = "View_Orders";
            this.Text = "View_Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewOrderPage;
        private System.Windows.Forms.Button btnBackOrd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblCustOrder;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnView;
    }
}