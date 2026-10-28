using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryMartinezRepaso
{
    public partial class frmArray : Form
    {
        //DECLARACION DE VARIABLES
        string[] PlanA = new string[4];
        string[] PlanB = new string[3];
        string[] PlanC = new string[3];


        public frmArray()
        {
            InitializeComponent();
        }

        private void frmArray_Load(object sender, EventArgs e)
        {
            cbCodigo.Items.Add("Plan A");
            cbCodigo.Items.Add("Plan B");
            cbCodigo.Items.Add("Plan C");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbCodigo.Text)
            {
                case "Plan A":
                    lstDatos.Items.Clear();
                    //lstDatos.Items.Add("CPU");
                    //lstDatos.Items.Add("Micro");
                    //lstDatos.Items.Add("Placa");
                    //lstDatos.Items.Add("Memoria");

                    //RECORRER Y MOSTRAR CODIGO

                    for (int i = 0; i < PlanA.Length; i++)
                    {
                        lstDatos.Items.Add(PlanA[i]);
                    }
                    break;

                case "Plan B":
                    lstDatos.Items.Clear();
                    //lstDatos.Items.Add("Visual");
                    //lstDatos.Items.Add("C#");
                    //lstDatos.Items.Add("Desktop");

                    //RECORRER Y MOSTRAR CODIGO

                    for (int i = 0; i < PlanB.Length; i++)
                    {
                        lstDatos.Items.Add(PlanB[i]);
                    }
                    break;
                case "Plan C":
                    lstDatos.Items.Clear();
                    //lstDatos.Items.Add("Server");
                    //lstDatos.Items.Add("AWS");
                    //lstDatos.Items.Add("Cloud");

                    //RECORRER Y MOSTRAR CODIGO

                    for (int i = 0; i < PlanA.Length; i++)
                    {
                        lstDatos.Items.Add(PlanC[i]);
                    }
                    break;
            }
        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanA[0] = "CPU";
            PlanA[1] = "Micro";
            PlanA[2] = "Server";
            PlanA[3] = "Memoria";

            PlanB[0] = "Visual";
            PlanA[1] = "C#";
            PlanA[2] = "Desktop";

            PlanC[0] = "Server";
            PlanC[1] = "AWS";
            PlanC[2] = "Cloud";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
