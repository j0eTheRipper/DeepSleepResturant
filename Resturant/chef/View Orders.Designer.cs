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
            this.lblshowDate = new System.Windows.Forms.Label();
            this.lblTotalShow = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.ViewList = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblStatusShow = new System.Windows.Forms.Label();
            this.OrderDetails = new System.Windows.Forms.GroupBox();
            this.OrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblViewOrderPage
            // 
            this.lblViewOrderPage.AutoSize = true;
            this.lblViewOrderPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrderPage.Location = new System.Drawing.Point(706, 15);
            this.lblViewOrderPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewOrderPage.Name = "lblViewOrderPage";
            this.lblViewOrderPage.Size = new System.Drawing.Size(130, 26);
            this.lblViewOrderPage.TabIndex = 19;
            this.lblViewOrderPage.Text = "View Orders";
            // 
            // btnBackOrd
            // 
            this.btnBackOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnBackOrd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOrd.Location = new System.Drawing.Point(876, 459);
            this.btnBackOrd.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackOrd.Name = "btnBackOrd";
            this.btnBackOrd.Size = new System.Drawing.Size(76, 31);
            this.btnBackOrd.TabIndex = 18;
            this.btnBackOrd.Text = "Back>";
            this.btnBackOrd.UseVisualStyleBackColor = false;
            this.btnBackOrd.Click += new System.EventHandler(this.btnBackOrd_Click);
            // 
            // lblshowDate
            // 
            this.lblshowDate.AutoSize = true;
            this.lblshowDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblshowDate.Location = new System.Drawing.Point(250, 176);
            this.lblshowDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblshowDate.Name = "lblshowDate";
            this.lblshowDate.Size = new System.Drawing.Size(2, 15);
            this.lblshowDate.TabIndex = 17;
            this.lblshowDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotalShow
            // 
            this.lblTotalShow.AutoSize = true;
            this.lblTotalShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalShow.Location = new System.Drawing.Point(250, 115);
            this.lblTotalShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalShow.Name = "lblTotalShow";
            this.lblTotalShow.Size = new System.Drawing.Size(2, 15);
            this.lblTotalShow.TabIndex = 16;
            this.lblTotalShow.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.Color.White;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerID.Location = new System.Drawing.Point(250, 47);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(2, 15);
            this.lblCustomerID.TabIndex = 15;
            this.lblCustomerID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(22, 177);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 14;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(22, 106);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(16, 47);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(65, 13);
            this.lblCustID.TabIndex = 12;
            this.lblCustID.Text = "Customer ID";
            // 
            // ViewList
            // 
            this.ViewList.BackColor = System.Drawing.Color.White;
            this.ViewList.FormattingEnabled = true;
            this.ViewList.Location = new System.Drawing.Point(23, 58);
            this.ViewList.Margin = new System.Windows.Forms.Padding(2);
            this.ViewList.Name = "ViewList";
            this.ViewList.Size = new System.Drawing.Size(391, 433);
            this.ViewList.TabIndex = 11;
            this.ViewList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnView.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(442, 453);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(82, 26);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View Order";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(22, 239);
            this.lblOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(66, 13);
            this.lblOrderStatus.TabIndex = 20;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // lblStatusShow
            // 
            this.lblStatusShow.AutoSize = true;
            this.lblStatusShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatusShow.Location = new System.Drawing.Point(250, 239);
            this.lblStatusShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusShow.Name = "lblStatusShow";
            this.lblStatusShow.Size = new System.Drawing.Size(2, 15);
            this.lblStatusShow.TabIndex = 21;
            // 
            // OrderDetails
            // 
            this.OrderDetails.BackColor = System.Drawing.Color.White;
            this.OrderDetails.Controls.Add(this.lblCustID);
            this.OrderDetails.Controls.Add(this.lblStatusShow);
            this.OrderDetails.Controls.Add(this.lblTotalPrice);
            this.OrderDetails.Controls.Add(this.lblOrderStatus);
            this.OrderDetails.Controls.Add(this.lblOrderDate);
            this.OrderDetails.Controls.Add(this.lblshowDate);
            this.OrderDetails.Controls.Add(this.lblCustomerID);
            this.OrderDetails.Controls.Add(this.lblTotalShow);
            this.OrderDetails.Location = new System.Drawing.Point(464, 81);
            this.OrderDetails.Margin = new System.Windows.Forms.Padding(2);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Padding = new System.Windows.Forms.Padding(2);
            this.OrderDetails.Size = new System.Drawing.Size(478, 315);
            this.OrderDetails.TabIndex = 22;
            this.OrderDetails.TabStop = false;
            this.OrderDetails.Text = "Order Details";
            // 
            // View_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(962, 500);
            this.Controls.Add(this.OrderDetails);
            this.Controls.Add(this.lblViewOrderPage);
            this.Controls.Add(this.btnBackOrd);
            this.Controls.Add(this.ViewList);
            this.Controls.Add(this.btnView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Orders";
            this.Load += new System.EventHandler(this.View_Orders_Load);
            this.OrderDetails.ResumeLayout(false);
            this.OrderDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewOrderPage;
        private System.Windows.Forms.Button btnBackOrd;
        private System.Windows.Forms.Label lblshowDate;
        private System.Windows.Forms.Label lblTotalShow;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.ListBox ViewList;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblStatusShow;
        private System.Windows.Forms.GroupBox OrderDetails;
    }
}