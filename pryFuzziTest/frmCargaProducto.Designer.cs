namespace pryFuzziTest
{
    partial class frmCargaProducto
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
            this.gbxLoadProd1 = new System.Windows.Forms.GroupBox();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.cbxProdList = new System.Windows.Forms.ComboBox();
            this.lblProdList = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbxLoadProd2 = new System.Windows.Forms.GroupBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.rbtRepuesto = new System.Windows.Forms.RadioButton();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.rbtEquipo = new System.Windows.Forms.RadioButton();
            this.gbxAdditional = new System.Windows.Forms.GroupBox();
            this.chkInstall = new System.Windows.Forms.CheckBox();
            this.chkWarranty = new System.Windows.Forms.CheckBox();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.gbxLoadProd1.SuspendLayout();
            this.gbxLoadProd2.SuspendLayout();
            this.gbxType.SuspendLayout();
            this.gbxAdditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLoadProd1
            // 
            this.gbxLoadProd1.Controls.Add(this.btnNext1);
            this.gbxLoadProd1.Controls.Add(this.cbxProdList);
            this.gbxLoadProd1.Controls.Add(this.lblProdList);
            this.gbxLoadProd1.Controls.Add(this.btnRegister);
            this.gbxLoadProd1.Controls.Add(this.lblName);
            this.gbxLoadProd1.Controls.Add(this.txtName);
            this.gbxLoadProd1.Location = new System.Drawing.Point(12, 12);
            this.gbxLoadProd1.Name = "gbxLoadProd1";
            this.gbxLoadProd1.Size = new System.Drawing.Size(310, 111);
            this.gbxLoadProd1.TabIndex = 6;
            this.gbxLoadProd1.TabStop = false;
            this.gbxLoadProd1.Text = "Opciones generales";
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(228, 83);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 23);
            this.btnNext1.TabIndex = 11;
            this.btnNext1.Text = "Siguiente";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // cbxProdList
            // 
            this.cbxProdList.FormattingEnabled = true;
            this.cbxProdList.Location = new System.Drawing.Point(80, 56);
            this.cbxProdList.Name = "cbxProdList";
            this.cbxProdList.Size = new System.Drawing.Size(187, 21);
            this.cbxProdList.TabIndex = 10;
            this.cbxProdList.SelectedIndexChanged += new System.EventHandler(this.cbxProdList_SelectedIndexChanged);
            // 
            // lblProdList
            // 
            this.lblProdList.AutoSize = true;
            this.lblProdList.Location = new System.Drawing.Point(-1, 59);
            this.lblProdList.Name = "lblProdList";
            this.lblProdList.Size = new System.Drawing.Size(75, 13);
            this.lblProdList.TabIndex = 9;
            this.lblProdList.Text = "Lista Producto";
            this.lblProdList.Click += new System.EventHandler(this.lblProdList_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(221, 23);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(83, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nombre";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // gbxLoadProd2
            // 
            this.gbxLoadProd2.Controls.Add(this.gbxAdditional);
            this.gbxLoadProd2.Controls.Add(this.gbxType);
            this.gbxLoadProd2.Controls.Add(this.cbxProduct);
            this.gbxLoadProd2.Controls.Add(this.lblProduct);
            this.gbxLoadProd2.Location = new System.Drawing.Point(12, 123);
            this.gbxLoadProd2.Name = "gbxLoadProd2";
            this.gbxLoadProd2.Size = new System.Drawing.Size(310, 183);
            this.gbxLoadProd2.TabIndex = 7;
            this.gbxLoadProd2.TabStop = false;
            this.gbxLoadProd2.Text = "Opciones adicionales";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(21, 26);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(50, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Producto";
            // 
            // cbxProduct
            // 
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(77, 23);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(139, 21);
            this.cbxProduct.TabIndex = 1;
            // 
            // rbtRepuesto
            // 
            this.rbtRepuesto.AutoSize = true;
            this.rbtRepuesto.Location = new System.Drawing.Point(9, 19);
            this.rbtRepuesto.Name = "rbtRepuesto";
            this.rbtRepuesto.Size = new System.Drawing.Size(71, 17);
            this.rbtRepuesto.TabIndex = 3;
            this.rbtRepuesto.TabStop = true;
            this.rbtRepuesto.Text = "Repuesto";
            this.rbtRepuesto.UseVisualStyleBackColor = true;
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rbtEquipo);
            this.gbxType.Controls.Add(this.rbtRepuesto);
            this.gbxType.Location = new System.Drawing.Point(24, 50);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(152, 43);
            this.gbxType.TabIndex = 4;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Tipo";
            // 
            // rbtEquipo
            // 
            this.rbtEquipo.AutoSize = true;
            this.rbtEquipo.Location = new System.Drawing.Point(86, 19);
            this.rbtEquipo.Name = "rbtEquipo";
            this.rbtEquipo.Size = new System.Drawing.Size(58, 17);
            this.rbtEquipo.TabIndex = 5;
            this.rbtEquipo.TabStop = true;
            this.rbtEquipo.Text = "Equipo";
            this.rbtEquipo.UseVisualStyleBackColor = true;
            // 
            // gbxAdditional
            // 
            this.gbxAdditional.Controls.Add(this.chkDelivery);
            this.gbxAdditional.Controls.Add(this.chkWarranty);
            this.gbxAdditional.Controls.Add(this.chkInstall);
            this.gbxAdditional.Location = new System.Drawing.Point(24, 101);
            this.gbxAdditional.Name = "gbxAdditional";
            this.gbxAdditional.Size = new System.Drawing.Size(152, 72);
            this.gbxAdditional.TabIndex = 5;
            this.gbxAdditional.TabStop = false;
            this.gbxAdditional.Text = "Adicional";
            // 
            // chkInstall
            // 
            this.chkInstall.AutoSize = true;
            this.chkInstall.Location = new System.Drawing.Point(9, 19);
            this.chkInstall.Name = "chkInstall";
            this.chkInstall.Size = new System.Drawing.Size(77, 17);
            this.chkInstall.TabIndex = 6;
            this.chkInstall.Text = "Instalación";
            this.chkInstall.UseVisualStyleBackColor = true;
            // 
            // chkWarranty
            // 
            this.chkWarranty.AutoSize = true;
            this.chkWarranty.Location = new System.Drawing.Point(9, 42);
            this.chkWarranty.Name = "chkWarranty";
            this.chkWarranty.Size = new System.Drawing.Size(68, 17);
            this.chkWarranty.TabIndex = 7;
            this.chkWarranty.Text = "Garantía";
            this.chkWarranty.UseVisualStyleBackColor = true;
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Location = new System.Drawing.Point(86, 19);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(55, 17);
            this.chkDelivery.TabIndex = 7;
            this.chkDelivery.Text = "Envío";
            this.chkDelivery.UseVisualStyleBackColor = true;
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(247, 312);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 8;
            this.btnNext2.Text = "Siguiente";
            this.btnNext2.UseVisualStyleBackColor = true;
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 347);
            this.Controls.Add(this.btnNext2);
            this.Controls.Add(this.gbxLoadProd2);
            this.Controls.Add(this.gbxLoadProd1);
            this.Name = "frmCargaProducto";
            this.Text = "Cargar Producto";
            this.gbxLoadProd1.ResumeLayout(false);
            this.gbxLoadProd1.PerformLayout();
            this.gbxLoadProd2.ResumeLayout(false);
            this.gbxLoadProd2.PerformLayout();
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.gbxAdditional.ResumeLayout(false);
            this.gbxAdditional.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLoadProd1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.ComboBox cbxProdList;
        private System.Windows.Forms.Label lblProdList;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbxLoadProd2;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.RadioButton rbtRepuesto;
        private System.Windows.Forms.GroupBox gbxAdditional;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.CheckBox chkWarranty;
        private System.Windows.Forms.CheckBox chkInstall;
        private System.Windows.Forms.RadioButton rbtEquipo;
        private System.Windows.Forms.Button btnNext2;
    }
}