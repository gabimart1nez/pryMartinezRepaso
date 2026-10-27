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
            string dato;
            dato=txtCodigo.Text;
            MessageBox.Show("Registrado con exito");
        }
    }
}
