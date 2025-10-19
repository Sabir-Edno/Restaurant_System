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
    public partial class FrrPOSScreen : Form
    {
        public FrrPOSScreen()
        {
            InitializeComponent();
        }

        private void FrrPOSScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnDineIn_Click(object sender, EventArgs e)
        {
            btnDineIn.FillColor = Color.FromArgb(245, 73, 39);
            btnDineIn.FillColor2 = Color.FromArgb(245, 73, 39);

            btnDelivery.FillColor = Color.Black;
            btnDelivery.FillColor2 = Color.Black;

            btnTakeAway.FillColor = Color.Black;
            btnTakeAway.FillColor2 = Color.Black;
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            btnTakeAway.FillColor = Color.FromArgb(245, 73, 39);
            btnTakeAway.FillColor2 = Color.FromArgb(245, 73, 39);

            btnDelivery.FillColor = Color.Black;
            btnDelivery.FillColor2 = Color.Black;

            btnDineIn.FillColor = Color.Black;
            btnDineIn.FillColor2 = Color.Black;
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {

            btnDelivery.FillColor = Color.FromArgb(245, 73, 39);
            btnDelivery.FillColor2 = Color.FromArgb(245, 73, 39);

            btnTakeAway.FillColor = Color.Black;
            btnTakeAway.FillColor2 = Color.Black;

            btnDineIn.FillColor = Color.Black;
            btnDineIn.FillColor2 = Color.Black;
        }
    }
}
