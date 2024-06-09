namespace Resturant.Customer
{
    partial class cMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.menuFilter1 = new Resturant.manage.MenuFilter();
            this.lblOrderS = new System.Windows.Forms.Label();
            this.btn2SeeORder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // GridItems
            // 
            this.GridItems.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.GridItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridItems.BackgroundColor = System.Drawing.Color.White;
            this.GridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridItems.Location = new System.Drawing.Point(781, 28);
            this.GridItems.Name = "GridItems";
            this.GridItems.ReadOnly = true;
            this.GridItems.RowHeadersWidth = 51;
            this.GridItems.RowTemplate.DividerHeight = 1;
            this.GridItems.RowTemplate.Height = 24;
            this.GridItems.Size = new System.Drawing.Size(375, 358);
            this.GridItems.TabIndex = 6;
            this.GridItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItems_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ITEM";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "QTY";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "COST";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(71, 407);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(101, 31);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(781, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(375, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "pay";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(27, 326);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(194, 23);
            this.btnAddToOrder.TabIndex = 9;
            this.btnAddToOrder.Text = "Add To order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(27, 363);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(194, 23);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(1107, 428);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(49, 20);
            this.lblcount.TabIndex = 12;
            this.lblcount.Text = "0.00$";
            this.lblcount.Click += new System.EventHandler(this.lblcount_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(781, 425);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(171, 23);
            this.btnTotal.TabIndex = 13;
            this.btnTotal.Text = "Total Amount";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // menuFilter1
            // 
            this.menuFilter1.BackColor = System.Drawing.Color.Transparent;
            this.menuFilter1.Location = new System.Drawing.Point(13, 13);
            this.menuFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.menuFilter1.Name = "menuFilter1";
            this.menuFilter1.Size = new System.Drawing.Size(621, 306);
            this.menuFilter1.TabIndex = 8;
            this.menuFilter1.Load += new System.EventHandler(this.menuFilter1_Load);
            // 
            // lblOrderS
            // 
            this.lblOrderS.AutoSize = true;
            this.lblOrderS.Location = new System.Drawing.Point(363, 407);
            this.lblOrderS.Name = "lblOrderS";
            this.lblOrderS.Size = new System.Drawing.Size(128, 16);
            this.lblOrderS.TabIndex = 14;
            this.lblOrderS.Text = "Your Order Stauts Is:";
            this.lblOrderS.Click += new System.EventHandler(this.lblOrderS_Click);
            // 
            // btn2SeeORder
            // 
            this.btn2SeeORder.Location = new System.Drawing.Point(352, 363);
            this.btn2SeeORder.Name = "btn2SeeORder";
            this.btn2SeeORder.Size = new System.Drawing.Size(261, 27);
            this.btn2SeeORder.TabIndex = 15;
            this.btn2SeeORder.Text = "Click to see your order status";
            this.btn2SeeORder.UseVisualStyleBackColor = true;
            this.btn2SeeORder.Click += new System.EventHandler(this.btn2SeeORder_Click);
            // 
            // cMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(114)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1168, 567);
            this.Controls.Add(this.btn2SeeORder);
            this.Controls.Add(this.lblOrderS);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.menuFilter1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.GridItems);
            this.Name = "cMenu";
            this.Text = "cMenu";
            this.Load += new System.EventHandler(this.cMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridItems;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button2;
        private manage.MenuFilter menuFilter1;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblOrderS;
        private System.Windows.Forms.Button btn2SeeORder;
    }
}