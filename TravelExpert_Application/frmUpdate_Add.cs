using Project_4_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpert_Application
{
    //Author: Yasin Habib
    public partial class frmUpdate_Add : Form
    {
        public frmUpdate_Add()
        {
            InitializeComponent();
        }
        public Packages packageNow; //new package
        public Packages packageOld; //old package from frmPackages
        public bool addPackage;
        List<Products> prod = null;

        //********Form Load: Setting up add/update*****
        private void frmUpdate_Add_Load(object sender, EventArgs e)
        {
            //Combobox for adding product, updates with product table
            prod = ProductDB.GetAllProducts();
            cboProducts.DataSource = prod.ToList();
            cboProducts.SelectedIndex = -1;
            cboProducts.DisplayMember = "ProdName";
            cboProducts.ValueMember = "ProdName";


            if (addPackage) // Add Package
            {
                btnSave.Enabled = false;
                txtDescription.Enabled = false;
                txtBasePrice.Enabled = false;
                this.Text = "Add Package";
                lblTitle.Text = "Add Package";
                lblPkgId.Visible = false;
                
            }
            else //Update Package
            {
                btnSave.Enabled = true;
                this.Text = "Update Package";
                lblTitle.Text = "Update Package";
                packagesBindingSource.Add(packageNow);

                //if (packageOld.Product != null)
                //{
                //    //lblProduct.Visible = false;
                //    //cboProducts.Visible = false; //Couldn't get update to work with Product, " System.NullReferenceException: 'Object reference not set to an instance of an object.' "
                //}
                //else
                //{
                //    lblProduct.Visible = true;
                //    cboProducts.Visible = true;
                //}

            }
        }
        //if name is not null, enable Description
        private void txtPkgName_TextChanged(object sender, EventArgs e)
        {
            if (txtPkgName.Text != "")
                txtDescription.Enabled = true;
        }
        //if description is not null, enable base price
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (txtDescription.Text != "")
                txtBasePrice.Enabled = true;
        }

        //***********BASE PRICE*************
        //if base price is not null, button active.
        private void txtBasePrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBasePrice.Text != "")
                btnSave.Enabled = true;
            //two decimal place
            decimal bp;
            decimal.TryParse(txtBasePrice.Text, out bp);
            txtBasePrice.Text = bp.ToString(".00"); //c2 does not show the value when updating, ex: shows $0.00, instead of **base price**
            //While entering price, the cursor moves to the right after typing the 1st number, such as 87 will type as 78. 
            //I was unable to fix the issue but you may have to click the right arrow key after typing the 1st number.
        }
        //Base price number only
        private void txtBasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                btnSave.Enabled = false;
            }
        }

        //*********AGENCY COMMISSION***********
        private void txtAgencyCommission_TextChanged(object sender, EventArgs e)
        {
            //Two Decimal on Agency commission
            decimal ac;
            decimal.TryParse(txtAgencyCommission.Text, out ac);
            txtAgencyCommission.Text = ac.ToString(".00");
        }
        private void txtAgencyCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number only
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //Setting max and min on start and end date
        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
            dateTimeStart.MaxDate = dateTimeEnd.Value.Date;
            dateTimeEnd.MinDate = dateTimeStart.Value.Date;

        }

        //*****************SAVE BUTTON(Update and Add)**********
        private void btnSave_Click(object sender, EventArgs e)
        {

            ////Adding
            if (addPackage)
            {
                packageNow = new Packages();
                this.PackageData(packageNow);

                //if (txtPkgName.Text == packageNow.PkgName)
                //{
                //    MessageBox.Show("There is already a existing package with this name, please try again");
                //    this.DialogResult = DialogResult.Retry;
                //}
                //else if (txtPkgName.Text != packageNow.PkgName) //only ELSE was giving the error message even if it wasn't equal(duplicate)
                //{
                    try
                    {
                        packageNow.PackgeId = PackageDB.AddPackage(packageNow);
                        this.DialogResult = DialogResult.OK; // OK if Insert was successful
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                        this.DialogResult = DialogResult.Retry;
                    }
                //}

            }

            ////Update
            else
            {
                Packages packageNow = new Packages();
                this.PackageData(packageNow);
                try
                {
                    bool success = PackageDB.UpdatePackage(packageOld, packageNow);
                    if (success)
                    {
                        this.DialogResult = DialogResult.OK;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    this.DialogResult = DialogResult.Retry;
                }
            }

        }


        //Package data with validation
        public void PackageData(Packages package)
        {
            if (Validation.ValidNull(txtPkgName))
                package.PkgName = txtPkgName.Text;

            //description
            if (Validation.ValidNull(txtDescription))
                package.PkgDesc = txtDescription.Text;

            //Start and End date

            //Start
            if (dateTimeStart.Checked)
            {
                if (Validation.ValidDateTime(dateTimeStart, dateTimeEnd))
                {
                    dateTimeStart.Format = DateTimePickerFormat.Long;
                    package.PkgStartDate = dateTimeStart.Value;
                }
            }
            else if (!dateTimeStart.Checked)
            {
                package.PkgStartDate = null;
            }

            //End
            if (dateTimeEnd.Checked)
            {
                //if (Validation.ValidDateTime(dateTimeStart, dateTimeEnd))
                //{
                    dateTimeEnd.Format = DateTimePickerFormat.Long;
                    package.PkgEndDate = dateTimeEnd.Value;
                //}
            }
            else if (!dateTimeEnd.Checked)
            {
                package.PkgEndDate = null;
            }

            //Agency commission (if left empty)
            if (string.IsNullOrEmpty(txtAgencyCommission.Text))
                package.PkgAgencyCommission = 0;
            else if (Validation.ValidNeg(txtAgencyCommission))
                package.PkgAgencyCommission = Convert.ToDecimal(txtAgencyCommission.Text);

            //Base price
            try
            {
                if (txtBasePrice.Text == "")
                    MessageBox.Show("Please enter a value for base price", "Input Error");
                else
                {
                    decimal basePrice = Convert.ToDecimal(txtBasePrice.Text);
                    decimal commissionPrice = Convert.ToDecimal(txtAgencyCommission.Text);
                    if (basePrice < commissionPrice)
                        MessageBox.Show("Base price needs to be higher than commission price");
                    else if (Validation.ValidNeg(txtBasePrice))
                        package.PkgBasePrice = basePrice;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("If agency commission is 0, please enter 0 in the field" + ex.Message, ex.GetType().ToString());
                this.DialogResult = DialogResult.Retry;
            }

            //Product
            if (cboProducts.SelectedValue != null)
                package.Product = cboProducts.SelectedValue.ToString();
            else
                package.Product = null;
        }


        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }//end of Update
}//End of namespace
