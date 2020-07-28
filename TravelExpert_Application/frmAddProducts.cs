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
    public partial class frmAddProduct : Form
    {
        //public Products productNow;     
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Products newProduct = new Products();

            //Validations
            //name
            if (Validation.ProductNotNull(txtName)) //&& ProductDB.IsProdNameUnique(txtName.Text))
            {             
                //if (Validation.UniqueName(txtName))
                //if(txtName.Text == newProduct.ProdName)               
                //{
                //    MessageBox.Show("Product Name already exists, it has to be unique", "Input Error");
                //    txtName.Focus();
                //}                                  
                newProduct.ProdName = txtName.Text;
            }
                                      
            try
            {
                newProduct.ProductId = ProductDB.AddProduct(newProduct);
                this.DialogResult = DialogResult.OK; // OK if Insert was successful
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }
}
