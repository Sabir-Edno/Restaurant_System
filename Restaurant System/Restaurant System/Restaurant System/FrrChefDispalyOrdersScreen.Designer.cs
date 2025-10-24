namespace Restaurant_System
{
    partial class FrrChefDispalyOrdersScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrrChefDispalyOrdersScreen));
            this.lblTotalOrders = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblScreenTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.FLPListOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPOrdersDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReferesh = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrders.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.lblTotalOrders.Location = new System.Drawing.Point(171, 195);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(30, 32);
            this.lblTotalOrders.TabIndex = 54;
            this.lblTotalOrders.Text = "???";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(47, 195);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(118, 32);
            this.guna2HtmlLabel6.TabIndex = 53;
            this.guna2HtmlLabel6.Text = "Total Orders : ";
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenTitle.Font = new System.Drawing.Font("Poppins SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.lblScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.lblScreenTitle.Location = new System.Drawing.Point(604, 26);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(506, 90);
            this.lblScreenTitle.TabIndex = 48;
            this.lblScreenTitle.Text = "Chef Display Orders";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FLPListOrders
            // 
            this.FLPListOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPListOrders.Location = new System.Drawing.Point(47, 229);
            this.FLPListOrders.Name = "FLPListOrders";
            this.FLPListOrders.Size = new System.Drawing.Size(1173, 695);
            this.FLPListOrders.TabIndex = 55;
            // 
            // FLPOrdersDetails
            // 
            this.FLPOrdersDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPOrdersDetails.Location = new System.Drawing.Point(1267, 229);
            this.FLPOrdersDetails.Name = "FLPOrdersDetails";
            this.FLPOrdersDetails.Size = new System.Drawing.Size(410, 695);
            this.FLPOrdersDetails.TabIndex = 56;
            // 
            // btnReferesh
            // 
            this.btnReferesh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnReferesh.BorderRadius = 15;
            this.btnReferesh.BorderThickness = 2;
            this.btnReferesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReferesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReferesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReferesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReferesh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReferesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReferesh.FillColor = System.Drawing.Color.Black;
            this.btnReferesh.FillColor2 = System.Drawing.Color.Black;
            this.btnReferesh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReferesh.ForeColor = System.Drawing.Color.White;
            this.btnReferesh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnReferesh.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnReferesh.Image = ((System.Drawing.Image)(resources.GetObject("btnReferesh.Image")));
            this.btnReferesh.ImageSize = new System.Drawing.Size(50, 50);
            this.btnReferesh.Location = new System.Drawing.Point(1156, 165);
            this.btnReferesh.Name = "btnReferesh";
            this.btnReferesh.Size = new System.Drawing.Size(64, 58);
            this.btnReferesh.TabIndex = 57;
            // 
            // FrrChefDispalyOrdersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1703, 982);
            this.Controls.Add(this.btnReferesh);
            this.Controls.Add(this.FLPOrdersDetails);
            this.Controls.Add(this.FLPListOrders);
            this.Controls.Add(this.lblTotalOrders);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.lblScreenTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrrChefDispalyOrdersScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrrChefDispalyOrdersScreen";
            this.Load += new System.EventHandler(this.FrrChefDispalyOrdersScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalOrders;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblScreenTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel FLPListOrders;
        private System.Windows.Forms.FlowLayoutPanel FLPOrdersDetails;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnReferesh;
    }
}