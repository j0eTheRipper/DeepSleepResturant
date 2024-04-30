namespace Resturant
{
    partial class CustomerMainPage
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
            this.Menu = new System.Windows.Forms.Button();
            this.View_Order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.S_Feedback = new System.Windows.Forms.Button();
            this.Update_Profile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(314, 72);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(181, 65);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // View_Order
            // 
            this.View_Order.Location = new System.Drawing.Point(496, 159);
            this.View_Order.Name = "View_Order";
            this.View_Order.Size = new System.Drawing.Size(159, 59);
            this.View_Order.TabIndex = 1;
            this.View_Order.Text = "View Order &\r\nAnd\r\nReservation status\r\n";
            this.View_Order.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Order Food";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // S_Feedback
            // 
            this.S_Feedback.Location = new System.Drawing.Point(154, 267);
            this.S_Feedback.Name = "S_Feedback";
            this.S_Feedback.Size = new System.Drawing.Size(159, 59);
            this.S_Feedback.TabIndex = 3;
            this.S_Feedback.Text = "Send Feedback";
            this.S_Feedback.UseVisualStyleBackColor = true;
            // 
            // Update_Profile
            // 
            this.Update_Profile.Location = new System.Drawing.Point(496, 267);
            this.Update_Profile.Name = "Update_Profile";
            this.Update_Profile.Size = new System.Drawing.Size(159, 59);
            this.Update_Profile.TabIndex = 4;
            this.Update_Profile.Text = "Update own profile";
            this.Update_Profile.UseVisualStyleBackColor = true;
            // 
            // CustomerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update_Profile);
            this.Controls.Add(this.S_Feedback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.View_Order);
            this.Controls.Add(this.Menu);
            this.Name = "CustomerMainPage";
            this.Text = "CustomerMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button View_Order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button S_Feedback;
        private System.Windows.Forms.Button Update_Profile;
    }
}