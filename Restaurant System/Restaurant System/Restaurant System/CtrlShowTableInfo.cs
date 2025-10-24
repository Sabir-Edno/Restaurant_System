using ClsInvetoryBusinessLayer;
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
    public partial class CtrlShowTableInfo : UserControl
    {
        ClsTable Table;

        public CtrlShowTableInfo()
        {
            InitializeComponent();
        }

        public void ResetValues()
        {
            Table = null;
            lblTableID.Text = "???";
            lblTableName.Text = "???";
            lblCapacity.Text = "???";
            lblStatus.Text = "???";
            lblCreatedAt.Text = "???";
            lblUpdatedAt.Text = "???";
        }

        public void LoadTableInfo(int TableID)
        {
            Table = ClsTable.FindByTableID(TableID);

            if (Table != null)
            {
                lblTableID.Text = TableID.ToString();
                lblTableName.Text = Table.TableName;
                lblCapacity.Text = Table.Capacity.ToString();
                lblStatus.Text = Table.Status;
                lblCreatedAt.Text = Table.CreatedAt.ToShortDateString();
                if (Table.Updated != DateTime.MinValue)
                    lblUpdatedAt.Text = Table.Updated.ToShortDateString();
                else
                    lblUpdatedAt.Text = "Not Updated Yet";
            }
            else
                MessageBox.Show($"Table With ID = {TableID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void CtrlShowTableInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
