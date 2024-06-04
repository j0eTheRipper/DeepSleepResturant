namespace Resturant.chef
{
    partial class ChefMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefMainPage));
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.lblChefMain = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(380, 225);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(167, 67);
            this.btnUpdateProfile.TabIndex = 9;
            this.btnUpdateProfile.Text = "Manege Chef\'s Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnInventory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(161, 225);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(167, 69);
            this.btnInventory.TabIndex = 8;
            this.btnInventory.Text = "Ingredients Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnManageOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrders.Location = new System.Drawing.Point(380, 127);
            this.btnManageOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(167, 67);
            this.btnManageOrders.TabIndex = 7;
            this.btnManageOrders.Text = "Manage Orders";
            this.btnManageOrders.UseVisualStyleBackColor = false;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(161, 127);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(167, 69);
            this.btnViewOrders.TabIndex = 6;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // lblChefMain
            // 
            this.lblChefMain.AutoSize = true;
            this.lblChefMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefMain.Location = new System.Drawing.Point(263, 35);
            this.lblChefMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChefMain.Name = "lblChefMain";
            this.lblChefMain.Size = new System.Drawing.Size(179, 26);
            this.lblChefMain.TabIndex = 5;
            this.lblChefMain.Text = "Chef\'s Main Page";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblChefMain);
            this.groupBox1.Controls.Add(this.btnUpdateProfile);
            this.groupBox1.Controls.Add(this.btnManageOrders);
            this.groupBox1.Controls.Add(this.btnInventory);
            this.groupBox1.Controls.Add(this.btnViewOrders);
            this.groupBox1.Location = new System.Drawing.Point(114, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 358);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(685, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // ChefMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 440);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChefMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefMainPage";
            this.Load += new System.EventHandler(this.ChefMainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Label lblChefMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}