namespace Restaurant_System
{
    partial class CtrlItemQuantity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlItemQuantity));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblRemove = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbItemImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tbItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIncrease = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnDecrease = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblRemove
            // 
            this.lblRemove.BackColor = System.Drawing.Color.Transparent;
            this.lblRemove.Font = new System.Drawing.Font("Poppins Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(427, 3);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(16, 32);
            this.lblRemove.TabIndex = 7;
            this.lblRemove.Text = "X";
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            // 
            // pbItemImage
            // 
            this.pbItemImage.Image = ((System.Drawing.Image)(resources.GetObject("pbItemImage.Image")));
            this.pbItemImage.ImageRotate = 0F;
            this.pbItemImage.Location = new System.Drawing.Point(13, 21);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbItemImage.Size = new System.Drawing.Size(30, 32);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 6;
            this.pbItemImage.TabStop = false;
            // 
            // tbItemName
            // 
            this.tbItemName.BackColor = System.Drawing.Color.Transparent;
            this.tbItemName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.tbItemName.BorderRadius = 10;
            this.tbItemName.BorderThickness = 2;
            this.tbItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbItemName.DefaultText = "";
            this.tbItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbItemName.FillColor = System.Drawing.Color.Black;
            this.tbItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbItemName.ForeColor = System.Drawing.Color.White;
            this.tbItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbItemName.Location = new System.Drawing.Point(117, 21);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.PlaceholderText = "Item Quantity";
            this.tbItemName.SelectedText = "";
            this.tbItemName.Size = new System.Drawing.Size(225, 34);
            this.tbItemName.TabIndex = 48;
            this.tbItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIncrease
            // 
            this.btnIncrease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnIncrease.BorderRadius = 15;
            this.btnIncrease.BorderThickness = 2;
            this.btnIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncrease.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIncrease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIncrease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncrease.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIncrease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIncrease.FillColor = System.Drawing.Color.Black;
            this.btnIncrease.FillColor2 = System.Drawing.Color.Black;
            this.btnIncrease.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIncrease.ForeColor = System.Drawing.Color.White;
            this.btnIncrease.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnIncrease.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnIncrease.Image = ((System.Drawing.Image)(resources.GetObject("btnIncrease.Image")));
            this.btnIncrease.ImageSize = new System.Drawing.Size(16, 16);
            this.btnIncrease.Location = new System.Drawing.Point(348, 21);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(35, 34);
            this.btnIncrease.TabIndex = 58;
            // 
            // btnDecrease
            // 
            this.btnDecrease.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnDecrease.BorderRadius = 15;
            this.btnDecrease.BorderThickness = 2;
            this.btnDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrease.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrease.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrease.FillColor = System.Drawing.Color.Black;
            this.btnDecrease.FillColor2 = System.Drawing.Color.Black;
            this.btnDecrease.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDecrease.ForeColor = System.Drawing.Color.White;
            this.btnDecrease.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnDecrease.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnDecrease.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrease.Image")));
            this.btnDecrease.ImageSize = new System.Drawing.Size(16, 16);
            this.btnDecrease.Location = new System.Drawing.Point(76, 21);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(35, 34);
            this.btnDecrease.TabIndex = 59;
            // 
            // CtrlItemQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.pbItemImage);
            this.Name = "CtrlItemQuantity";
            this.Size = new System.Drawing.Size(449, 76);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRemove;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbItemImage;
        private Guna.UI2.WinForms.Guna2TextBox tbItemName;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnIncrease;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnDecrease;
    }
}
