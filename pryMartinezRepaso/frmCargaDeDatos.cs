using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryMartinezRepaso
{
    public partial class frmCargaDeDatos : Form
    {
        public frmCargaDeDatos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nombre;
            nombre = txtNombre.Text;
            codigo = int.Parse(txtCodigo.Text);
            MessageBox.Show("El codigo es: "+ codigo+". El nombre es: "+nombre);
        }
    }
}
