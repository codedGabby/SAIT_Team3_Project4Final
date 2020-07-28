namespace TravelExpert_Application
{
    partial class frmSuppliers
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
            System.Windows.Forms.Label supplierIDLabel2;
            System.Windows.Forms.Label supNameLabel2;
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnGetSup = new System.Windows.Forms.Button();
            this.cboSupName = new System.Windows.Forms.ComboBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.suppliersDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            supplierIDLabel2 = new System.Windows.Forms.Label();
            supNameLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierIDLabel2
            // 
            supplierIDLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierIDLabel2.Location = new System.Drawing.Point(32, 405);
            supplierIDLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supplierIDLabel2.Name = "supplierIDLabel2";
            supplierIDLabel2.Size = new System.Drawing.Size(136, 17);
            supplierIDLabel2.TabIndex = 6;
            supplierIDLabel2.Text = "Select Supplier Name:";
            // 
            // supNameLabel2
            // 
            supNameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel2.Location = new System.Drawing.Point(32, 465);
            supNameLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supNameLabel2.Name = "supNameLabel2";
            supNameLabel2.Size = new System.Drawing.Size(121, 19);
            supNameLabel2.TabIndex = 4;
            supNameLabel2.Text = "Supplier Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(238, 497);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 24);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(427, 497);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 24);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSupName
            // 
            this.txtSupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "SupName", true));
            this.txtSupName.Location = new System.Drawing.Point(192, 464);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(239, 20);
            this.txtSupName.TabIndex = 5;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataSource = typeof(Project_4_Data.Suppliers);
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(149, 8);
            this.txtSupID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(82, 20);
            this.txtSupID.TabIndex = 7;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(256, 4);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(81, 24);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnGetSup
            // 
            this.btnGetSup.Location = new System.Drawing.Point(22, 7);
            this.btnGetSup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetSup.Name = "btnGetSup";
            this.btnGetSup.Size = new System.Drawing.Size(80, 25);
            this.btnGetSup.TabIndex = 9;
            this.btnGetSup.Text = "Get Supplier";
            this.btnGetSup.UseVisualStyleBackColor = true;
            this.btnGetSup.Click += new System.EventHandler(this.btnGetSup_Click);
            // 
            // cboSupName
            // 
            this.cboSupName.FormattingEnabled = true;
            this.cboSupName.Location = new System.Drawing.Point(192, 404);
            this.cboSupName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSupName.Name = "cboSupName";
            this.cboSupName.Size = new System.Drawing.Size(239, 21);
            this.cboSupName.TabIndex = 10;
            this.cboSupName.SelectedIndexChanged += new System.EventHandler(this.cboSupName_SelectedIndexChanged);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUpdate.Location = new System.Drawing.Point(35, 497);
            this.btnAddUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(74, 25);
            this.btnAddUpdate.TabIndex = 11;
            this.btnAddUpdate.Text = "&Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.clmModify});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Location = new System.Drawing.Point(22, 46);
            this.suppliersDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.RowHeadersWidth = 62;
            this.suppliersDataGridView.RowTemplate.Height = 28;
            this.suppliersDataGridView.Size = new System.Drawing.Size(485, 341);
            this.suppliersDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 280;
            // 
            // clmModify
            // 
            this.clmModify.HeaderText = "Modify";
            this.clmModify.MinimumWidth = 8;
            this.clmModify.Name = "clmModify";
            this.clmModify.Text = "Modify";
            this.clmModify.UseColumnTextForButtonValue = true;
            this.clmModify.Visible = false;
            this.clmModify.Width = 150;
            // 
            // suppliersDBBindingSource
            // 
            this.suppliersDBBindingSource.DataSource = typeof(Project_4_Data.SuppliersDB);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Sup Name from Above DropBox for UPDATE or Input A new Name and Click ADD";
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(543, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suppliersDataGridView);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.cboSupName);
            this.Controls.Add(this.btnGetSup);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(supNameLabel2);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(supplierIDLabel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSuppliers";
            this.Text = "frmSuppliers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSuppliers_FormClosing);
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.BindingSource suppliersDBBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnGetSup;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cboSupName;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn clmModify;
        private System.Windows.Forms.Label label1;
    }
}