using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryMartinezRepaso
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void cbIva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int monto;
            monto = int.Parse(txtMonto.Text);
            //float resultado;
            
            }
            
        }
    }

