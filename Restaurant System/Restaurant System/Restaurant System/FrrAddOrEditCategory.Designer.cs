namespace Restaurant_System
{
    partial class FrrAddOrEditCategory
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tbCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCategoryID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitleMode = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUpdatedAt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUpdateAtTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCreatedAt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCreatedAtTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnClose.Location = new System.Drawing.Point(562, 484);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 45);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderThickness = 2;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.FillColor2 = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnSave.Location = new System.Drawing.Point(562, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 45);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.Transparent;
            this.tbDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.tbDescription.BorderRadius = 10;
            this.tbDescription.BorderThickness = 2;
            this.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescription.DefaultText = "";
            this.tbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescription.FillColor = System.Drawing.Color.Black;
            this.tbDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDescription.ForeColor = System.Drawing.Color.White;
            this.tbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescription.Location = new System.Drawing.Point(188, 229);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "Enter Description";
            this.tbDescription.SelectedText = "";
            this.tbDescription.Size = new System.Drawing.Size(225, 140);
            this.tbDescription.TabIndex = 49;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 230);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(116, 33);
            this.guna2HtmlLabel1.TabIndex = 48;
            this.guna2HtmlLabel1.Text = "Description : ";
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
            // tbCategoryName
            // 
            this.tbCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.tbCategoryName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.tbCategoryName.BorderRadius = 10;
            this.tbCategoryName.BorderThickness = 2;
            this.tbCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCategoryName.DefaultText = "";
            this.tbCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCategoryName.FillColor = System.Drawing.Color.Black;
            this.tbCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCategoryName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbCategoryName.ForeColor = System.Drawing.Color.White;
            this.tbCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCategoryName.Location = new System.Drawing.Point(188, 171);
            this.tbCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.PlaceholderText = "Enter Category Name";
            this.tbCategoryName.SelectedText = "";
            this.tbCategoryName.Size = new System.Drawing.Size(225, 34);
            this.tbCategoryName.TabIndex = 47;
            this.tbCategoryName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCategoryName_Validating);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 172);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(152, 33);
            this.guna2HtmlLabel2.TabIndex = 46;
            this.guna2HtmlLabel2.Text = "CategoryName : ";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryID.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCategoryID.ForeColor = System.Drawing.Color.White;
            this.lblCategoryID.Location = new System.Drawing.Point(188, 117);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(137, 33);
            this.lblCategoryID.TabIndex = 45;
            this.lblCategoryID.Text = "Not Adding Yet";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 117);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(115, 33);
            this.guna2HtmlLabel3.TabIndex = 44;
            this.guna2HtmlLabel3.Text = "CategoryID : ";
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(718, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 43;
            // 
            // lblTitleMode
            // 
            this.lblTitleMode.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleMode.Font = new System.Drawing.Font("Poppins SemiBold", 23F, System.Drawing.FontStyle.Bold);
            this.lblTitleMode.ForeColor = System.Drawing.Color.White;
            this.lblTitleMode.Location = new System.Drawing.Point(216, 12);
            this.lblTitleMode.Name = "lblTitleMode";
            this.lblTitleMode.Size = new System.Drawing.Size(364, 69);
            this.lblTitleMode.TabIndex = 42;
            this.lblTitleMode.Text = "Add New Category";
            this.lblTitleMode.Click += new System.EventHandler(this.lblTitleMode_Click);
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdatedAt.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lblUpdatedAt.ForeColor = System.Drawing.Color.White;
            this.lblUpdatedAt.Location = new System.Drawing.Point(188, 442);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(150, 33);
            this.lblUpdatedAt.TabIndex = 66;
            this.lblUpdatedAt.Text = "Not Updated Yet";
            // 
            // lblUpdateAtTitle
            // 
            this.lblUpdateAtTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateAtTitle.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lblUpdateAtTitle.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAtTitle.Location = new System.Drawing.Point(14, 442);
            this.lblUpdateAtTitle.Name = "lblUpdateAtTitle";
            this.lblUpdateAtTitle.Size = new System.Drawing.Size(111, 33);
            this.lblUpdateAtTitle.TabIndex = 65;
            this.lblUpdateAtTitle.Text = "UpdatedAt : ";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedAt.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCreatedAt.ForeColor = System.Drawing.Color.White;
            this.lblCreatedAt.Location = new System.Drawing.Point(188, 389);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(145, 33);
            this.lblCreatedAt.TabIndex = 64;
            this.lblCreatedAt.Text = "Not Created Yet";
            // 
            // lblCreatedAtTitle
            // 
            this.lblCreatedAtTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedAtTitle.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCreatedAtTitle.ForeColor = System.Drawing.Color.White;
            this.lblCreatedAtTitle.Location = new System.Drawing.Point(14, 389);
            this.lblCreatedAtTitle.Name = "lblCreatedAtTitle";
            this.lblCreatedAtTitle.Size = new System.Drawing.Size(106, 33);
            this.lblCreatedAtTitle.TabIndex = 63;
            this.lblCreatedAtTitle.Text = "CreatedAt : ";
            // 
            // FrrAddOrEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(776, 541);
            this.Controls.Add(this.lblUpdatedAt);
            this.Controls.Add(this.lblUpdateAtTitle);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.lblCreatedAtTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblTitleMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrrAddOrEditCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrrAddOrEditCategory";
            this.Load += new System.EventHandler(this.FrrAddOrEditCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnSave;
        private Guna.UI2.WinForms.Guna2TextBox tbDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbCategoryName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoryID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleMode;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUpdatedAt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUpdateAtTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreatedAt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCreatedAtTitle;
    }
}