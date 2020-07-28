namespace TravelExpert_Application
{
    partial class frmProducts
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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Project_4_Data.Products);
            // 
            // grdProducts
            // 
            this.grdProducts.AutoGenerateColumns = false;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.clmModify});
            this.grdProducts.DataSource = this.productsBindingSource;
            this.grdProducts.Location = new System.Drawing.Point(52, 42);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.Size = new System.Drawing.Size(346, 368);
            this.grdProducts.TabIndex = 1;
            this.grdProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // clmModify
            // 
            this.clmModify.DataPropertyName = "ProductId";
            this.clmModify.HeaderText = "Modify";
            this.clmModify.Name = "clmModify";
            this.clmModify.Text = "Modify";
            this.clmModify.UseColumnTextForButtonValue = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(52, 431);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(156, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add &Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(245, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(456, 505);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.grdProducts);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn clmModify;
    }
}