namespace TravelExpert_Application
{
    partial class frmUpdate_Products_Sup
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
            this.products_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // products_SupplierBindingSource
            // 
            this.products_SupplierBindingSource.DataSource = typeof(Project_4_Data.Products_Supplier);
            // 
            // pSDataGridView
            // 
            this.pSDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.pSDataGridView.AutoGenerateColumns = false;
            this.pSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.pSDataGridView.DataSource = this.products_SupplierBindingSource;
            this.pSDataGridView.Location = new System.Drawing.Point(35, 28);
            this.pSDataGridView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pSDataGridView.Name = "pSDataGridView";
            this.pSDataGridView.RowHeadersVisible = false;
            this.pSDataGridView.RowHeadersWidth = 102;
            this.pSDataGridView.RowTemplate.Height = 40;
            this.pSDataGridView.Size = new System.Drawing.Size(407, 420);
            this.pSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductSupplierId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product SupplierId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product and Supplier List";
            // 
            // frmUpdate_Products_Sup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(462, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pSDataGridView);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmUpdate_Products_Sup";
            this.Text = "frmUpdate_Products_Sup";
            this.Load += new System.EventHandler(this.frmUpdate_Products_Sup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource products_SupplierBindingSource;
        private System.Windows.Forms.DataGridView pSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
    }
}