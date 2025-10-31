namespace Restaurant_System
{
    partial class CtrlItemIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlItemIcon));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblItemName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbItemImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Poppins SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(3, 82);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(21, 24);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "???";
            // 
            // pbItemImage
            // 
            this.pbItemImage.Image = ((System.Drawing.Image)(resources.GetObject("pbItemImage.Image")));
            this.pbItemImage.ImageRotate = 0F;
            this.pbItemImage.Location = new System.Drawing.Point(26, 25);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbItemImage.Size = new System.Drawing.Size(56, 53);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 3;
            this.pbItemImage.TabStop = false;
            // 
            // CtrlItemIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.pbItemImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CtrlItemIcon";
            this.Size = new System.Drawing.Size(113, 106);
            this.Load += new System.EventHandler(this.CtrlItem_Load);
            this.Click += new System.EventHandler(this.CtrlItemIcon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblItemName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbItemImage;
    }
}
