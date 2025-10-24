namespace Restaurant_System
{
    partial class FrrShowUserInfo
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitleMode = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ctrlShowUserInfo1 = new Restaurant_System.CtrlShowUserInfo();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnClose.BorderRadius = 15;
            this.btnClose.BorderThickness = 2;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Black;
            this.btnClose.FillColor2 = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnClose.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnClose.Location = new System.Drawing.Point(629, 535);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 45);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(788, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 66;
            // 
            // lblTitleMode
            // 
            this.lblTitleMode.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleMode.Font = new System.Drawing.Font("Poppins SemiBold", 23F, System.Drawing.FontStyle.Bold);
            this.lblTitleMode.ForeColor = System.Drawing.Color.White;
            this.lblTitleMode.Location = new System.Drawing.Point(307, 7);
            this.lblTitleMode.Name = "lblTitleMode";
            this.lblTitleMode.Size = new System.Drawing.Size(283, 69);
            this.lblTitleMode.TabIndex = 65;
            this.lblTitleMode.Text = "Show User Info";
            // 
            // ctrlShowUserInfo1
            // 
            this.ctrlShowUserInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ctrlShowUserInfo1.Location = new System.Drawing.Point(40, 78);
            this.ctrlShowUserInfo1.Name = "ctrlShowUserInfo1";
            this.ctrlShowUserInfo1.Size = new System.Drawing.Size(754, 443);
            this.ctrlShowUserInfo1.TabIndex = 68;
            // 
            // FrrShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(845, 594);
            this.Controls.Add(this.ctrlShowUserInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblTitleMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrrShowUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrrShowUserInfo";
            this.Load += new System.EventHandler(this.FrrShowUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleMode;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private CtrlShowUserInfo ctrlShowUserInfo1;
    }
}