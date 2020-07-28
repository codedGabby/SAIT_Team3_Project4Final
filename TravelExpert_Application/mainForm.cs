using System;
using System.Windows.Forms;

namespace TravelExpert_Application
{
    
    //Author: Yasin Habib
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            frmPackages packages = new frmPackages();
            packages.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            products.ShowDialog();
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            frmUpdate_Products_Sup ps = new frmUpdate_Products_Sup();
            ps.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers sup = new frmSuppliers();
            sup.ShowDialog();
        }
    }
}
