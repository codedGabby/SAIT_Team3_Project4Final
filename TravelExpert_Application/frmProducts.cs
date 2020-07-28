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
    public partial class frmProducts : Form
    {
        const int MODIFY = 2; //Update button on column index 2
        List<Products> products;
        Products oldProduct;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void loadProducts()
        {
            try
            {
                products = ProductDB.GetAllProducts();
                grdProducts.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading products: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void grdProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == MODIFY)
            {
                oldProduct = products[e.RowIndex].ProductBackup();
                frmEdit_Add update = new frmEdit_Add();
                update.productNow = products[e.RowIndex];   // current product
                update.productOld = oldProduct;             // older product, from frmProduct
                DialogResult result = update.ShowDialog();
                if (result == DialogResult.OK) // update accepted
                {
                    loadProducts();                   
                }
                else // update cancelled
                {
                    products[e.RowIndex] = oldProduct; // revert to the old values
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            frmAddProduct add = new frmAddProduct();
            
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK) // Adding accepted
            {
                // refresh the grid view
                loadProducts();              
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
