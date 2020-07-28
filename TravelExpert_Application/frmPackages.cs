using Project_4_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpert_Application
{
    //Author: Yasin Habib
    public partial class frmPackages : Form
    {
        const int UPDATE = 8; //Update button on column index 7
        List<Packages> packages;
        Packages oldPackage;
        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            LoadPackages();
        }//End of form load

        private void grdPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == UPDATE)
            {
                oldPackage = packages[e.RowIndex].PackageBackup();
                frmUpdate_Add update = new frmUpdate_Add();
                update.packageNow = packages[e.RowIndex];   // current package
                update.packageOld = oldPackage;             // older package (from frmPackage)
                DialogResult result = update.ShowDialog();
                if (result == DialogResult.OK) // update accepted
                {
                    // refresh the grid view
                    LoadPackages();
                    MessageBox.Show(update.packageNow.PkgName + " has been updated successfully!");
                }
                else // update cancelled
                {
                    packages[e.RowIndex] = oldPackage; // revert to the old values
                }
            }
        }//End of Update click

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUpdate_Add add = new frmUpdate_Add();
            add.addPackage = true;
            DialogResult result = add.ShowDialog();

            if (result == DialogResult.OK) // Adding accepted
            {
                // refresh the grid view
                LoadPackages();
                MessageBox.Show(add.packageNow.PkgName + " has been added to the database");
            }

        }

        private void LoadPackages()
        {
            try
            {
                Refresh();
                packages = PackageDB.GetAllPackages();
                grdPackages.DataSource = packages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading packages: " + ex.Message,
                    ex.GetType().ToString());
            }
        }
    }//End of frmPackage
}//End of namespace
