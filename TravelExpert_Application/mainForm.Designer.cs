namespace TravelExpert_Application
{
    partial class mainForm
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
            this.btnPackage = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnPS = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPackage
            // 
            this.btnPackage.BackColor = System.Drawing.Color.Teal;
            this.btnPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackage.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnPackage.Location = new System.Drawing.Point(27, 40);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(180, 40);
            this.btnPackage.TabIndex = 0;
            this.btnPackage.Text = "Packages";
            this.btnPackage.UseVisualStyleBackColor = false;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.Teal;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSuppliers.Location = new System.Drawing.Point(27, 103);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(180, 40);
            this.btnSuppliers.TabIndex = 1;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Teal;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnProducts.Location = new System.Drawing.Point(27, 163);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(180, 40);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnPS
            // 
            this.btnPS.BackColor = System.Drawing.Color.Teal;
            this.btnPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPS.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnPS.Location = new System.Drawing.Point(27, 220);
            this.btnPS.Name = "btnPS";
            this.btnPS.Size = new System.Drawing.Size(180, 40);
            this.btnPS.TabIndex = 3;
            this.btnPS.Text = "Product Suppliers";
            this.btnPS.UseVisualStyleBackColor = false;
            this.btnPS.Click += new System.EventHandler(this.btnPS_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(81, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(243, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPS);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnPackage);
            this.Name = "mainForm";
            this.Text = "Travel Agency";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnPS;
        private System.Windows.Forms.Button btnExit;
    }
}