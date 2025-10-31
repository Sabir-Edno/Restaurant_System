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
    public partial class FrrDashboardScreen : Form
    {
        public FrrDashboardScreen()
        {
            InitializeComponent();
        }

        private void FrrDashboardScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            FrrPOSScreen frr = new FrrPOSScreen();

            PanelCenter.Controls.Clear();
            frr.TopLevel = false;
            frr.BringToFront();
            PanelCenter.Controls.Add(frr);
            frr.Show();
        }

        private void btnUserManagment_Click(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
            FrrUserManagmentScreen frr = new FrrUserManagmentScreen();
            frr.TopLevel = false;
            frr.BringToFront();
            PanelCenter.Controls.Add(frr);
            frr.Show();
        }

        private void btnTableManagement_Click(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
            FrrTableManagementScreen frr = new FrrTableManagementScreen();
            frr.TopLevel = false;
            frr.BringToFront();
            PanelCenter.Controls.Add(frr);
            frr.Show();
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
            FrrInventoryMangementScreen frr = new FrrInventoryMangementScreen();
            frr.TopLevel = false;
            frr.BringToFront();
            PanelCenter.Controls.Add(frr);
            frr.Show();
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
            FrrCategoryManagementScreen frr = new FrrCategoryManagementScreen();
            frr.TopLevel = false;
            frr.BringToFront();
            PanelCenter.Controls.Add(frr);
            frr.Show();
        }

        private void btnItemManagement_Click(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
            FrrItemManagementScreen frr = new FrrItemManagementScreen();
            frr.TopLevel = false;
            frr.BringToFront();
            PanelCenter.Controls.Add(frr);
            frr.Show();
        }
    }
}
