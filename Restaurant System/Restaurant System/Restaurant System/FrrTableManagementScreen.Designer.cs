namespace Restaurant_System
{
    partial class FrrTableManagementScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrrTableManagementScreen));
            this.lblScreenTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbOccupied = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAvailable = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblTotalRecords = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVTables = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewTable = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.rbReserved = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTables)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblScreenTitle.Font = new System.Drawing.Font("Poppins SemiBold", 30F, System.Drawing.FontStyle.Bold);
            this.lblScreenTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.lblScreenTitle.Location = new System.Drawing.Point(631, 35);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(472, 90);
            this.lblScreenTitle.TabIndex = 1;
            this.lblScreenTitle.Text = "Table Managment";
            // 
            // rbOccupied
            // 
            this.rbOccupied.AutoSize = true;
            this.rbOccupied.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOccupied.CheckedState.BorderThickness = 0;
            this.rbOccupied.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOccupied.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOccupied.CheckedState.InnerOffset = -4;
            this.rbOccupied.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOccupied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.rbOccupied.Location = new System.Drawing.Point(595, 297);
            this.rbOccupied.Name = "rbOccupied";
            this.rbOccupied.Size = new System.Drawing.Size(110, 30);
            this.rbOccupied.TabIndex = 46;
            this.rbOccupied.Text = "Occupied ";
            this.rbOccupied.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbOccupied.UncheckedState.BorderThickness = 2;
            this.rbOccupied.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOccupied.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbOccupied.Visible = false;
            this.rbOccupied.CheckedChanged += new System.EventHandler(this.rbOccupied_CheckedChanged);
            // 
            // rbAvailable
            // 
            this.rbAvailable.AutoSize = true;
            this.rbAvailable.Checked = true;
            this.rbAvailable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAvailable.CheckedState.BorderThickness = 0;
            this.rbAvailable.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAvailable.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAvailable.CheckedState.InnerOffset = -4;
            this.rbAvailable.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.rbAvailable.Location = new System.Drawing.Point(462, 297);
            this.rbAvailable.Name = "rbAvailable";
            this.rbAvailable.Size = new System.Drawing.Size(108, 30);
            this.rbAvailable.TabIndex = 45;
            this.rbAvailable.TabStop = true;
            this.rbAvailable.Text = "Available ";
            this.rbAvailable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAvailable.UncheckedState.BorderThickness = 2;
            this.rbAvailable.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAvailable.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAvailable.Visible = false;
            this.rbAvailable.CheckedChanged += new System.EventHandler(this.rbAvailable_CheckedChanged);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRecords.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.lblTotalRecords.Location = new System.Drawing.Point(202, 946);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(27, 28);
            this.lblTotalRecords.TabIndex = 40;
            this.lblTotalRecords.Text = "???";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(119, 945);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(73, 28);
            this.guna2HtmlLabel6.TabIndex = 39;
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
            this.tbFilter.Location = new System.Drawing.Point(462, 293);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PlaceholderText = "Filter";
            this.tbFilter.SelectedText = "";
            this.tbFilter.Size = new System.Drawing.Size(225, 34);
            this.tbFilter.TabIndex = 38;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Poppins SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(119, 293);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(80, 33);
            this.guna2HtmlLabel5.TabIndex = 37;
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
            this.cbFilter.Location = new System.Drawing.Point(209, 291);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(209, 36);
            this.cbFilter.TabIndex = 36;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // DGVTables
            // 
            this.DGVTables.AllowUserToAddRows = false;
            this.DGVTables.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DGVTables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVTables.ColumnHeadersHeight = 30;
            this.DGVTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTables.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGVTables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTables.Location = new System.Drawing.Point(119, 345);
            this.DGVTables.Name = "DGVTables";
            this.DGVTables.ReadOnly = true;
            this.DGVTables.RowHeadersVisible = false;
            this.DGVTables.RowHeadersWidth = 51;
            this.DGVTables.RowTemplate.Height = 24;
            this.DGVTables.Size = new System.Drawing.Size(1465, 594);
            this.DGVTables.TabIndex = 35;
            this.DGVTables.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTables.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVTables.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVTables.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVTables.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVTables.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVTables.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTables.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVTables.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVTables.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTables.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVTables.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVTables.ThemeStyle.HeaderStyle.Height = 30;
            this.DGVTables.ThemeStyle.ReadOnly = true;
            this.DGVTables.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVTables.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVTables.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVTables.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVTables.ThemeStyle.RowsStyle.Height = 24;
            this.DGVTables.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVTables.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 100);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.addNewUserToolStripMenuItem.Text = "Show Table Info";
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.updateUserToolStripMenuItem.Text = "Add New Table";
            // 
            // updateUserToolStripMenuItem1
            // 
            this.updateUserToolStripMenuItem1.Name = "updateUserToolStripMenuItem1";
            this.updateUserToolStripMenuItem1.Size = new System.Drawing.Size(196, 24);
            this.updateUserToolStripMenuItem1.Text = "Update Table Info";
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete Table";
            // 
            // btnAddNewTable
            // 
            this.btnAddNewTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewTable.BorderRadius = 15;
            this.btnAddNewTable.BorderThickness = 2;
            this.btnAddNewTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewTable.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewTable.FillColor = System.Drawing.Color.Black;
            this.btnAddNewTable.FillColor2 = System.Drawing.Color.Black;
            this.btnAddNewTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewTable.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTable.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewTable.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.btnAddNewTable.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewTable.Image")));
            this.btnAddNewTable.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewTable.Location = new System.Drawing.Point(1520, 281);
            this.btnAddNewTable.Name = "btnAddNewTable";
            this.btnAddNewTable.Size = new System.Drawing.Size(64, 58);
            this.btnAddNewTable.TabIndex = 47;
            this.btnAddNewTable.Click += new System.EventHandler(this.btnAddNewTable_Click);
            // 
            // rbReserved
            // 
            this.rbReserved.AutoSize = true;
            this.rbReserved.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbReserved.CheckedState.BorderThickness = 0;
            this.rbReserved.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbReserved.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbReserved.CheckedState.InnerOffset = -4;
            this.rbReserved.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReserved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
            this.rbReserved.Location = new System.Drawing.Point(722, 297);
            this.rbReserved.Name = "rbReserved";
            this.rbReserved.Size = new System.Drawing.Size(103, 30);
            this.rbReserved.TabIndex = 48;
            this.rbReserved.Text = "Reserved";
            this.rbReserved.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbReserved.UncheckedState.BorderThickness = 2;
            this.rbReserved.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbReserved.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbReserved.Visible = false;
            this.rbReserved.CheckedChanged += new System.EventHandler(this.rbReserved_CheckedChanged);
            // 
            // FrrTableManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1703, 982);
            this.Controls.Add(this.rbReserved);
            this.Controls.Add(this.btnAddNewTable);
            this.Controls.Add(this.rbOccupied);
            this.Controls.Add(this.rbAvailable);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.DGVTables);
            this.Controls.Add(this.lblScreenTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrrTableManagementScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrrTableManagementScreen";
            this.Load += new System.EventHandler(this.FrrTableManagementScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTables)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblScreenTitle;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnAddNewTable;
        private Guna.UI2.WinForms.Guna2RadioButton rbOccupied;
        private Guna.UI2.WinForms.Guna2RadioButton rbAvailable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalRecords;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox tbFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2DataGridView DGVTables;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2RadioButton rbReserved;
    }
}