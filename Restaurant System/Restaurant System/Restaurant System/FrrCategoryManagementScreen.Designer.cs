namespace Restaurant_System
{
    partial class FrrCategoryManagementScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrrCategoryManagementScreen));
            this.lblTotalRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVCategories = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScreenTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAddNewCategory = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.lblTotalRecords.Location = new System.Drawing.Point(202, 934);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(27, 28);
            this.lblTotalRecords.TabIndex = 54;
            this.lblTotalRecords.Text = "???";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(119, 933);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(73, 28);
            this.guna2HtmlLabel6.TabIndex = 53;
            this.guna2HtmlLabel6.Text = "Records : ";
            // 
            // tbFilter
            // 
            this.tbFilter.BackColor = System.Drawing.Color.Transparent;
            this.tbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.tbFilter.BorderRadius = 10;
            this.tbFilter.BorderThickness = 2;
            this.tbFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFilter.DefaultText = "";
            this.tbFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFilter.FillColor = System.Drawing.Color.Black;
            this.tbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFilter.Location = new System.Drawing.Point(462, 281);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PlaceholderText = "Filter";
            this.tbFilter.SelectedText = "";
            this.tbFilter.Size = new System.Drawing.Size(225, 34);
            this.tbFilter.TabIndex = 52;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(119, 281);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(80, 33);
            this.guna2HtmlLabel5.TabIndex = 51;
            this.guna2HtmlLabel5.Text = "FilterBy : ";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.White;
            this.cbFilter.BorderRadius = 10;
            this.cbFilter.BorderThickness = 2;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FillColor = System.Drawing.Color.Black;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Location = new System.Drawing.Point(209, 279);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(209, 36);
            this.cbFilter.TabIndex = 50;
            // 
            // DGVCategories
            // 
            this.DGVCategories.AllowUserToAddRows = false;
            this.DGVCategories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVCategories.ColumnHeadersHeight = 30;
            this.DGVCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVCategories.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCategories.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCategories.Location = new System.Drawing.Point(119, 333);
            this.DGVCategories.Name = "DGVCategories";
            this.DGVCategories.ReadOnly = true;
            this.DGVCategories.RowHeadersVisible = false;
            this.DGVCategories.RowHeadersWidth = 51;
            this.DGVCategories.RowTemplate.Height = 24;
            this.DGVCategories.Size = new System.Drawing.Size(1465, 594);
            this.DGVCategories.TabIndex = 49;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVCategories.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVCategories.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVCategories.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVCategories.ThemeStyle.ReadOnly = true;
            this.DGVCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVCategories.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVCategories.ThemeStyle.RowsStyle.Height = 24;
            this.DGVCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.updateUserToolStripMenuItem1,
            this.deleteUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 100);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.addNewUserToolStripMenuItem.Text = "Show Category Info";
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.updateUserToolStripMenuItem.Text = "Add New Category";
            // 
            // updateUserToolStripMenuItem1
            // 
            this.updateUserToolStripMenuItem1.Name = "updateUserToolStripMenuItem1";
            this.updateUserToolStripMenuItem1.Size = new System.Drawing.Size(221, 24);
            this.updateUserToolStripMenuItem1.Text = "Update Category Info";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete Category";
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenTitle.Font = new System.Drawing.Font("Poppins SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.lblScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.lblScreenTitle.Location = new System.Drawing.Point(568, 22);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(568, 90);
            this.lblScreenTitle.TabIndex = 48;
            this.lblScreenTitle.Text = "Category Managment";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnAddNewCategory
            // 
            this.btnAddNewCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewCategory.BorderRadius = 15;
            this.btnAddNewCategory.BorderThickness = 2;
            this.btnAddNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCategory.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCategory.FillColor = System.Drawing.Color.Black;
            this.btnAddNewCategory.FillColor2 = System.Drawing.Color.Black;
            this.btnAddNewCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCategory.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewCategory.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCategory.Image")));
            this.btnAddNewCategory.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewCategory.Location = new System.Drawing.Point(1520, 269);
            this.btnAddNewCategory.Name = "btnAddNewCategory";
            this.btnAddNewCategory.Size = new System.Drawing.Size(64, 58);
            this.btnAddNewCategory.TabIndex = 57;
            // 
            // FrrCategoryManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1703, 982);
            this.Controls.Add(this.btnAddNewCategory);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.DGVCategories);
            this.Controls.Add(this.lblScreenTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrrCategoryManagementScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrrCategoryManagementScreen";
            this.Load += new System.EventHandler(this.FrrCategoryManagementScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddNewCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox tbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2DataGridView DGVCategories;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblScreenTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
    }
}