namespace TravelExpert_Application
{
    partial class frmUpdate_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label LBLId;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate_Add));
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            this.txtAgencyCommission = new System.Windows.Forms.TextBox();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.lblPkgId = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            LBLId = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLId
            // 
            resources.ApplyResources(LBLId, "LBLId");
            LBLId.Name = "LBLId";
            // 
            // pkgAgencyCommissionLabel
            // 
            resources.ApplyResources(pkgAgencyCommissionLabel, "pkgAgencyCommissionLabel");
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            // 
            // pkgBasePriceLabel
            // 
            resources.ApplyResources(pkgBasePriceLabel, "pkgBasePriceLabel");
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            // 
            // pkgDescLabel
            // 
            resources.ApplyResources(pkgDescLabel, "pkgDescLabel");
            pkgDescLabel.Name = "pkgDescLabel";
            // 
            // pkgEndDateLabel
            // 
            resources.ApplyResources(pkgEndDateLabel, "pkgEndDateLabel");
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            // 
            // pkgNameLabel
            // 
            resources.ApplyResources(pkgNameLabel, "pkgNameLabel");
            pkgNameLabel.Name = "pkgNameLabel";
            // 
            // pkgStartDateLabel
            // 
            resources.ApplyResources(pkgStartDateLabel, "pkgStartDateLabel");
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgAgencyCommission", true));
            resources.ApplyResources(this.txtAgencyCommission, "txtAgencyCommission");
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.TextChanged += new System.EventHandler(this.txtAgencyCommission_TextChanged);
            this.txtAgencyCommission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgencyCommission_KeyPress);
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataSource = typeof(Project_4_Data.Packages);
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgBasePrice", true));
            resources.ApplyResources(this.txtBasePrice, "txtBasePrice");
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.TextChanged += new System.EventHandler(this.txtBasePrice_TextChanged);
            this.txtBasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasePrice_KeyPress);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPkgName
            // 
            this.txtPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgName", true));
            resources.ApplyResources(this.txtPkgName, "txtPkgName");
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.TextChanged += new System.EventHandler(this.txtPkgName_TextChanged);
            // 
            // lblPkgId
            // 
            resources.ApplyResources(this.lblPkgId, "lblPkgId");
            this.lblPkgId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PackgeId", true));
            this.lblPkgId.Name = "lblPkgId";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgDesc", true));
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // dateTimeEnd
            // 
            resources.ApplyResources(this.dateTimeEnd, "dateTimeEnd");
            this.dateTimeEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgEndDate", true));
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.ShowCheckBox = true;
            // 
            // dateTimeStart
            // 
            resources.ApplyResources(this.dateTimeStart, "dateTimeStart");
            this.dateTimeStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgStartDate", true));
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.ShowCheckBox = true;
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimeStart_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblProduct
            // 
            resources.ApplyResources(this.lblProduct, "lblProduct");
            this.lblProduct.Name = "lblProduct";
            // 
            // cboProducts
            // 
            this.cboProducts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.productsBindingSource, "ProdName", true));
            this.cboProducts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "ProdName", true));
            this.cboProducts.DataSource = this.productsBindingSource;
            this.cboProducts.DisplayMember = "ProdName";
            this.cboProducts.FormattingEnabled = true;
            resources.ApplyResources(this.cboProducts, "cboProducts");
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.ValueMember = "ProdName";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Project_4_Data.Products);
            // 
            // frmUpdate_Add
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPkgId);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(LBLId);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.txtAgencyCommission);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.dateTimeStart);
            this.Name = "frmUpdate_Add";
            this.Load += new System.EventHandler(this.frmUpdate_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAgencyCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.Label lblPkgId;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cboProducts;
    }
}