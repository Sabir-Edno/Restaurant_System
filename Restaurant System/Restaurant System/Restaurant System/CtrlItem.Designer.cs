namespace Restaurant_System
{
    partial class CtrlItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlItem));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbItemImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblRemove = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblItemName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.guna2Panel1.Controls.Add(this.lblItemName);
            this.guna2Panel1.Controls.Add(this.lblRemove);
            this.guna2Panel1.Controls.Add(this.pbItemImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(104, 98);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pbItemImage
            // 
            this.pbItemImage.Image = ((System.Drawing.Image)(resources.GetObject("pbItemImage.Image")));
            this.pbItemImage.ImageRotate = 0F;
            this.pbItemImage.Location = new System.Drawing.Point(23, 19);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbItemImage.Size = new System.Drawing.Size(56, 53);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 0;
            this.pbItemImage.TabStop = false;
            // 
            // lblRemove
            // 
            this.lblRemove.BackColor = System.Drawing.Color.Transparent;
            this.lblRemove.Font = new System.Drawing.Font("Poppins Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(2, 0);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(16, 32);
            this.lblRemove.TabIndex = 1;
            this.lblRemove.Text = "X";
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Poppins SemiBold", 7F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(5, 73);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(21, 24);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "???";
            // 
            // CtrlItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "CtrlItem";
            this.Size = new System.Drawing.Size(104, 98);
            this.Load += new System.EventHandler(this.CtrlItem_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbItemImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRemove;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblItemName;
    }
}
