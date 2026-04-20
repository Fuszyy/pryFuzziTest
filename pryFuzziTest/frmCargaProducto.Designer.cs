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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblProdList = new System.Windows.Forms.Label();
            this.cbxProdList = new System.Windows.Forms.ComboBox();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(239, 24);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(83, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblProdList
            // 
            this.lblProdList.AutoSize = true;
            this.lblProdList.Location = new System.Drawing.Point(10, 60);
            this.lblProdList.Name = "lblProdList";
            this.lblProdList.Size = new System.Drawing.Size(75, 13);
            this.lblProdList.TabIndex = 3;
            this.lblProdList.Text = "Lista Producto";
            // 
            // cbxProdList
            // 
            this.cbxProdList.FormattingEnabled = true;
            this.cbxProdList.Location = new System.Drawing.Point(91, 57);
            this.cbxProdList.Name = "cbxProdList";
            this.cbxProdList.Size = new System.Drawing.Size(187, 21);
            this.cbxProdList.TabIndex = 4;
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(247, 112);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 23);
            this.btnNext1.TabIndex = 5;
            this.btnNext1.Text = "Siguiente";
            this.btnNext1.UseVisualStyleBackColor = true;
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 149);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.cbxProdList);
            this.Controls.Add(this.lblProdList);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "frmCargaProducto";
            this.Text = "frmCargaProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblProdList;
        private System.Windows.Forms.ComboBox cbxProdList;
        private System.Windows.Forms.Button btnNext1;
    }
}