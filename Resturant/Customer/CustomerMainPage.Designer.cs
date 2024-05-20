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
            this.View_order = new System.Windows.Forms.Button();
            this.Order_food = new System.Windows.Forms.Button();
            this.S_feedback = new System.Windows.Forms.Button();
            this.Update_profile = new System.Windows.Forms.Button();
            this.Reservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(419, 75);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(241, 80);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // View_order
            // 
            this.View_order.Location = new System.Drawing.Point(661, 196);
            this.View_order.Margin = new System.Windows.Forms.Padding(4);
            this.View_order.Name = "View_order";
            this.View_order.Size = new System.Drawing.Size(212, 73);
            this.View_order.TabIndex = 1;
            this.View_order.Text = "View Order &\r\nAnd\r\nReservation status\r\n";
            this.View_order.UseVisualStyleBackColor = true;
            this.View_order.Click += new System.EventHandler(this.View_order_Click);
            // 
            // Order_food
            // 
            this.Order_food.Location = new System.Drawing.Point(205, 196);
            this.Order_food.Margin = new System.Windows.Forms.Padding(4);
            this.Order_food.Name = "Order_food";
            this.Order_food.Size = new System.Drawing.Size(212, 73);
            this.Order_food.TabIndex = 2;
            this.Order_food.Text = "Order Food";
            this.Order_food.UseVisualStyleBackColor = true;
            this.Order_food.Click += new System.EventHandler(this.button1_Click);
            // 
            // S_feedback
            // 
            this.S_feedback.Location = new System.Drawing.Point(439, 468);
            this.S_feedback.Margin = new System.Windows.Forms.Padding(4);
            this.S_feedback.Name = "S_feedback";
            this.S_feedback.Size = new System.Drawing.Size(212, 73);
            this.S_feedback.TabIndex = 3;
            this.S_feedback.Text = "Send Feedback";
            this.S_feedback.UseVisualStyleBackColor = true;
            this.S_feedback.Click += new System.EventHandler(this.S_feedback_Click);
            // 
            // Update_profile
            // 
            this.Update_profile.Location = new System.Drawing.Point(661, 329);
            this.Update_profile.Margin = new System.Windows.Forms.Padding(4);
            this.Update_profile.Name = "Update_profile";
            this.Update_profile.Size = new System.Drawing.Size(212, 73);
            this.Update_profile.TabIndex = 4;
            this.Update_profile.Text = "Update own profile";
            this.Update_profile.UseVisualStyleBackColor = true;
            // 
            // Reservation
            // 
            this.Reservation.Location = new System.Drawing.Point(205, 329);
            this.Reservation.Margin = new System.Windows.Forms.Padding(4);
            this.Reservation.Name = "Reservation";
            this.Reservation.Size = new System.Drawing.Size(212, 73);
            this.Reservation.TabIndex = 5;
            this.Reservation.Text = "Reservation";
            this.Reservation.UseVisualStyleBackColor = true;
            this.Reservation.Click += new System.EventHandler(this.Reservation_Click);
            // 
            // CustomerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Reservation);
            this.Controls.Add(this.Update_profile);
            this.Controls.Add(this.S_feedback);
            this.Controls.Add(this.Order_food);
            this.Controls.Add(this.View_order);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerMainPage";
            this.Text = "CustomerMainPage";
            this.Load += new System.EventHandler(this.CustomerMainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button View_order;
        private System.Windows.Forms.Button Order_food;
        private System.Windows.Forms.Button S_feedback;
        private System.Windows.Forms.Button Update_profile;
        private System.Windows.Forms.Button Reservation;
    }
}