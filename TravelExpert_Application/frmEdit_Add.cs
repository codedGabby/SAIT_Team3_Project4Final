using Project_4_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author: Muhammad Suaid

namespace TravelExpert_Application
{
    public partial class frmEdit_Add : Form
    {
        public Products productNow; //new updated product
        public Products productOld; //old product from frmProducts
        
        public frmEdit_Add()
        {
            InitializeComponent();
        }

        private void frmEdit_Add_Load(object sender, EventArgs e)
        {          
            productsBindingSource.Add(productNow);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = ProductDB.UpdateProduct(productOld, productNow);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Retry;
            }
        }        
    }
}
