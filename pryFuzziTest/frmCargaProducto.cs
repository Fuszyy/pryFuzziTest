using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFuzziTest
{
    public partial class frmCargaProducto : Form
    {
        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            if(cbxProdList.SelectedItem != null)
            {
                gbxLoadProd2.Visible = true;
            }
            else
            {
                MessageBox.Show("Completar los datos", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cbxProdList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProdList_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                cbxProdList.Enabled = true;
                MessageBox.Show("Acceso Autorizado.", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxProdList.Items.Add((string)txtName.Text);
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("Completar los datos", "Error al acceder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtName.Text != "")
                {
                    cbxProdList.Enabled = true;
                    MessageBox.Show("Acceso Autorizado.", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Completar los datos", "Error al acceder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
