using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project_4_Data;

// Gabriel Sofekun


namespace TravelExpert_Application
{
    public partial class frmUpdate_Products_Sup : Form
    {

        List<Products_Supplier> products_Supplier;
        public frmUpdate_Products_Sup()
        {
            InitializeComponent();
        }

        private void frmUpdate_Products_Sup_Load(object sender, EventArgs e)
        {
            products_Supplier = Products_SupplierDB.GetProducts_Suppliers();
            pSDataGridView.DataSource = products_Supplier;
        }

    }
}
