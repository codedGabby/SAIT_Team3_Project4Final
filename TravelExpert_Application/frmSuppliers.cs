using Project_4_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Author: Tony Onyeka
*/

/* Copy the below code to SQL and execute 

create PROC [dbo].[spInsertSupplier]
           --@productId int,
          @SupplierName  nvarchar(50)


AS
BEGIN TRANSACTION
   DECLARE @SupplierId int;
   SELECT @SupplierId = coalesce((select max(SupplierId) + 1 from Suppliers), 1)
COMMIT
--IF NOT EXISTS(SELECT * FROM Products WHERE ProductId = @ProductId)
INSERT Suppliers
VALUES ( @SupplierId, @SupplierName);
SELECT *
FROM Suppliers
where SupplierId = @SupplierId;
RETURN @SupplierId;
GO 
*/
namespace TravelExpert_Application
{
    public partial class frmSuppliers : Form
    {
        private Suppliers supplier;
        public bool addSupplier;
        //Suppliers current = null; // current member
        // List<int> suppliers; // all members IDs
        List<Suppliers> sup;
        Suppliers oldSupplier;

        //int supId = 0;

        const int MODIFY = 2;

        public frmSuppliers()
        {
            InitializeComponent();
            
        }

        


        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            
            LoadComboAndGrid();
            //refreshdata();

            suppliersBindingSource.Add(supplier);

            btnModify.Enabled = false;
            txtSupID.Enabled = false;
            btnGetSup.Enabled = false;
            //txtSupName.Enabled = false;
        }

        private void LoadComboAndGrid()

        {
            SqlConnection connection = TravelExpertConnection.GetConnection();
            // we can get the Supname..
            string query = "SELECT SupplierId, SupName from Suppliers order by SupName";
            SqlDataAdapter supp = new SqlDataAdapter(query, connection);
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable tab = new DataTable();
            supp.Fill(tab);
            
            cboSupName.DataSource = tab;
            cboSupName.DisplayMember = "SupName";
            cboSupName.ValueMember = "SupplierId";
            this.cboSupName.SelectedIndex = -1;
            //cmd.ExecuteNonQuery();
            suppliersDataGridView.DataSource = SuppliersDB.GetAllSuppliers();
            
        }

        

        private void btnGetSup_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSupID) &&
                Validator.IsInt32(txtSupID))
            {
                int SupplierId = Convert.ToInt32(txtSupID.Text);
                this.GetSupplier(SupplierId);
                if (supplier == null) // no Supplier with this ID
                {
                    MessageBox.Show("No Supplier found with this ID. " +
                         "Please try again.", "Supplier Not Found");
                    this.ClearControls();
                }
                else // there is a possible Supplier ID to be displayed
                    this.DisplaySuppliers();
            }
            btnModify.Enabled = true;
        }

        private void DisplaySuppliers()
        {
            txtSupName.Text = supplier.SupName;
            //btnAdd.Enabled = true;
            btnModify.Enabled = true;
        }

        private void ClearControls()
        {
            txtSupID.Text = "";
            txtSupName.Text = "";
            //btnAdd.Enabled = false;
            btnModify.Enabled = false;
            txtSupID.Select();
        }

        private void GetSupplier(int supplierId)
        {
            try
            {
                supplier = SuppliersDB.GetSupplier(supplierId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSupName))
                //&& !Validator.UserInputDataExists(txtSupName))
                
            {

                supplier = new Suppliers();
                
                supplier.SupName = txtSupName.Text;
                    // add SupID code ... called ADD function txtSupName.Text = supplier.SupName;
                supplier.SupplierId = SuppliersDB.AddSupplier(supplier);


                LoadComboAndGrid();
            }
            else
            {
                MessageBox.Show("Type in Supplier Name if none exists");
                this.DialogResult = DialogResult.Retry;
            }

            txtSupName.Text = "";
        }

       
       

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            {
                
                using (SqlConnection connection = TravelExpertConnection.GetConnection())
                {
                    if (Validator.IsPresent(txtSupName))
                    {
                        connection.Open();
                        SqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Suppliers set SupName='" + txtSupName.Text + "'" +
                            "where SupplierId='" + cboSupName.SelectedValue + "'";
                        cmd.ExecuteNonQuery();
                        connection.Close();

                    }
                }
                suppliersDataGridView.DataSource = SuppliersDB.GetAllSuppliers();
                LoadComboAndGrid();
                txtSupName.Text = "";
            }
        }

       
       
       

        private void cboSupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = TravelExpertConnection.GetConnection();
            string query = "select * from Suppliers where SupName = '" + cboSupName.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
                
            SqlDataReader dr;
            try
            {
                con.Open();
                dr =  cmd.ExecuteReader();
                while (dr.Read())
                {
                    string supname = (string)dr["SupName"];
                    txtSupName.Text = supname;
                }
                //dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();  // Also this.Close();
        }

        private void frmSuppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sure! And you want to Close this APP?", "Form Closing", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
