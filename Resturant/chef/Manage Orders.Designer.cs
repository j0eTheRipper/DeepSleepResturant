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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.DataOfOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataOfOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackManageOrders
            // 
            this.btnBackManageOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnBackManageOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackManageOrders.Location = new System.Drawing.Point(781, 449);
            this.btnBackManageOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackManageOrders.Name = "btnBackManageOrders";
            this.btnBackManageOrders.Size = new System.Drawing.Size(74, 29);
            this.btnBackManageOrders.TabIndex = 1;
            this.btnBackManageOrders.Text = "Back >";
            this.btnBackManageOrders.UseVisualStyleBackColor = false;
            this.btnBackManageOrders.Click += new System.EventHandler(this.btnBackManageOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Orders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnReady.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(703, 285);
            this.btnReady.Margin = new System.Windows.Forms.Padding(2);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(112, 41);
            this.btnReady.TabIndex = 7;
            this.btnReady.Text = "Update to \"READY\"";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnInProgress
            // 
            this.btnInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnInProgress.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInProgress.Location = new System.Drawing.Point(559, 285);
            this.btnInProgress.Margin = new System.Windows.Forms.Padding(2);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(112, 41);
            this.btnInProgress.TabIndex = 8;
            this.btnInProgress.Text = "Update to \"IN PROGRESS\"";
            this.btnInProgress.UseVisualStyleBackColor = false;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter the Order Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(625, 242);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(122, 20);
            this.txtOrderId.TabIndex = 13;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // DataOfOrders
            // 
            this.DataOfOrders.BackgroundColor = System.Drawing.Color.White;
            this.DataOfOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOfOrders.Location = new System.Drawing.Point(9, 51);
            this.DataOfOrders.Margin = new System.Windows.Forms.Padding(2);
            this.DataOfOrders.Name = "DataOfOrders";
            this.DataOfOrders.RowHeadersWidth = 51;
            this.DataOfOrders.RowTemplate.Height = 24;
            this.DataOfOrders.Size = new System.Drawing.Size(533, 427);
            this.DataOfOrders.TabIndex = 14;
            // 
            // Manage_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(864, 488);
            this.Controls.Add(this.DataOfOrders);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInProgress);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackManageOrders);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Manage_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Orders";
            this.Load += new System.EventHandler(this.Manage_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOfOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackManageOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.DataGridView DataOfOrders;
    }
}