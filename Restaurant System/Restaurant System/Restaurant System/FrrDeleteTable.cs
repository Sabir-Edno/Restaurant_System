using ClsInvetoryBusinessLayer;
using ClsMenuTableBusinessLayer;
using ClsTableBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class FrrDeleteTable : Form
    {
        int _TableID = -1;

        public FrrDeleteTable(int TableID)
        {
            InitializeComponent();

            _TableID = TableID;
        }

        private void _LoadTableInfo()
        {
            ClsTable Table = ClsTable.FindByTableID(_TableID);

            if (Table != null)
            {
                ctrlShowTableInfo1.LoadTableInfo(Table.TableID);
                btnDelete.Enabled = true;
            }
            else
                MessageBox.Show($"Table With ID = {_TableID} Not Found", "Not Found");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are You Do You Want To Delete Table With ID = {_TableID}", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                if (!ClsTable.IsItemReferenceToAnyOrderByID(_TableID))
                {
                    if (ClsTable.DeleteTable(_TableID))
                        MessageBox.Show($"Table With ID = {_TableID} Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"Table With ID = {_TableID} Not Deleted", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show($"Table With ID = {_TableID} [ It has References to rows on Orders go delete them and try again ]", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrrDeleteTable_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            _LoadTableInfo();
        }
    }
}
