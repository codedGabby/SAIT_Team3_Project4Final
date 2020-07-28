namespace TravelExpert_Application
{
    partial class frmEdit_Add
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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label productIdLabel;
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodNameTextBox = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            prodNameLabel = new System.Windows.Forms.Label();
            productIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Location = new System.Drawing.Point(24, 96);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(78, 13);
            prodNameLabel.TabIndex = 1;
            prodNameLabel.Text = "Product Name:";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Location = new System.Drawing.Point(43, 49);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new System.Drawing.Size(59, 13);
            productIdLabel.TabIndex = 3;
            productIdLabel.Text = "Product Id:";
            //productIdLabel.Click += new System.EventHandler(this.productIdLabel_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(Project_4_Data.Products);
            // 
            // prodNameTextBox
            // 
            this.prodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProdName", true));
            this.prodNameTextBox.Location = new System.Drawing.Point(130, 93);
            this.prodNameTextBox.Name = "prodNameTextBox";
            this.prodNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.prodNameTextBox.TabIndex = 2;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductId", true));
            this.productIdTextBox.Enabled = false;
            this.productIdTextBox.Location = new System.Drawing.Point(130, 49);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.productIdTextBox.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEdit_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 241);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameTextBox);
            this.Controls.Add(productIdLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Name = "frmEdit_Add";
            this.Text = "frmEdit_Add";
            this.Load += new System.EventHandler(this.frmEdit_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}