namespace Restaurant_System
{
    partial class FrrItemManagementScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrrItemManagementScreen));
            this.rbOutOfStock = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbInStock = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblTotalRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowItemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblScreenTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAddNewItem = new Guna.UI2.WinForms.Guna2GradientTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbOutOfStock
            // 
            this.rbOutOfStock.AutoSize = true;
            this.rbOutOfStock.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOutOfStock.CheckedState.BorderThickness = 0;
            this.rbOutOfStock.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOutOfStock.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOutOfStock.CheckedState.InnerOffset = -4;
            this.rbOutOfStock.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutOfStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.rbOutOfStock.Location = new System.Drawing.Point(586, 285);
            this.rbOutOfStock.Name = "rbOutOfStock";
            this.rbOutOfStock.Size = new System.Drawing.Size(121, 30);
            this.rbOutOfStock.TabIndex = 56;
            this.rbOutOfStock.Text = "OutOfStock";
            this.rbOutOfStock.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbOutOfStock.UncheckedState.BorderThickness = 2;
            this.rbOutOfStock.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOutOfStock.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbOutOfStock.Visible = false;
            this.rbOutOfStock.CheckedChanged += new System.EventHandler(this.rbOutOfStock_CheckedChanged);
            // 
            // rbInStock
            // 
            this.rbInStock.AutoSize = true;
            this.rbInStock.Checked = true;
            this.rbInStock.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInStock.CheckedState.BorderThickness = 0;
            this.rbInStock.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInStock.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInStock.CheckedState.InnerOffset = -4;
            this.rbInStock.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.rbInStock.Location = new System.Drawing.Point(472, 285);
            this.rbInStock.Name = "rbInStock";
            this.rbInStock.Size = new System.Drawing.Size(90, 30);
            this.rbInStock.TabIndex = 55;
            this.rbInStock.TabStop = true;
            this.rbInStock.Text = "InStock";
            this.rbInStock.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbInStock.UncheckedState.BorderThickness = 2;
            this.rbInStock.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInStock.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbInStock.Visible = false;
            this.rbInStock.CheckedChanged += new System.EventHandler(this.rbInStock_CheckedChanged);
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
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
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
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // DGVItems
            // 
            this.DGVItems.AllowUserToAddRows = false;
            this.DGVItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVItems.ColumnHeadersHeight = 30;
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVItems.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVItems.Location = new System.Drawing.Point(119, 333);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            this.DGVItems.RowHeadersVisible = false;
            this.DGVItems.RowHeadersWidth = 51;
            this.DGVItems.RowTemplate.Height = 24;
            this.DGVItems.Size = new System.Drawing.Size(1465, 594);
            this.DGVItems.TabIndex = 49;
            this.DGVItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVItems.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVItems.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVItems.ThemeStyle.ReadOnly = true;
            this.DGVItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVItems.ThemeStyle.RowsStyle.Height = 24;
            this.DGVItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowItemInfoToolStripMenuItem,
            this.AddNewItemToolStripMenuItem,
            this.UpdateItemToolStripMenuItem1,
            this.deleteUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 100);
            // 
            // ShowItemInfoToolStripMenuItem
            // 
            this.ShowItemInfoToolStripMenuItem.Name = "ShowItemInfoToolStripMenuItem";
            this.ShowItemInfoToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.ShowItemInfoToolStripMenuItem.Text = "Show Item Info";
            this.ShowItemInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowItemInfoToolStripMenuItem_Click);
            // 
            // AddNewItemToolStripMenuItem
            // 
            this.AddNewItemToolStripMenuItem.Name = "AddNewItemToolStripMenuItem";
            this.AddNewItemToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.AddNewItemToolStripMenuItem.Text = "Add New Item";
            this.AddNewItemToolStripMenuItem.Click += new System.EventHandler(this.AddNewItemToolStripMenuItem_Click);
            // 
            // UpdateItemToolStripMenuItem1
            // 
            this.UpdateItemToolStripMenuItem1.Name = "UpdateItemToolStripMenuItem1";
            this.UpdateItemToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.UpdateItemToolStripMenuItem1.Text = "Update Item Info";
            this.UpdateItemToolStripMenuItem1.Click += new System.EventHandler(this.UpdateItemToolStripMenuItem1_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete Item";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenTitle.Font = new System.Drawing.Font("Poppins SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.lblScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.lblScreenTitle.Location = new System.Drawing.Point(629, 21);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(446, 90);
            this.lblScreenTitle.TabIndex = 48;
            this.lblScreenTitle.Text = "Item Managment";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewItem.BorderRadius = 15;
            this.btnAddNewItem.BorderThickness = 2;
            this.btnAddNewItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewItem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewItem.FillColor = System.Drawing.Color.Black;
            this.btnAddNewItem.FillColor2 = System.Drawing.Color.Black;
            this.btnAddNewItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.btnAddNewItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewItem.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewItem.Image")));
            this.btnAddNewItem.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewItem.Location = new System.Drawing.Point(1520, 269);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(64, 58);
            this.btnAddNewItem.TabIndex = 57;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // FrrItemManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1703, 982);
            this.Controls.Add(this.rbOutOfStock);
            this.Controls.Add(this.rbInStock);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.DGVItems);
            this.Controls.Add(this.lblScreenTitle);
            this.Controls.Add(this.btnAddNewItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrrItemManagementScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrrMenuItemManagementScreen";
            this.Load += new System.EventHandler(this.FrrMenuItemManagementScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RadioButton rbOutOfStock;
        private Guna.UI2.WinForms.Guna2RadioButton rbInStock;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox tbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2DataGridView DGVItems;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblScreenTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowItemInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateItemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddNewItem;
    }
}