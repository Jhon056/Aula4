﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Você precisa digitar um número para calcular", 
                                "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double numero, resultado;
                numero = double.Parse(txtNumero.Text);

                for(int i = 0; i <= 10; i++)
                {
                    resultado = numero * i;
                    txtTabuada.Text += numero + " X " + i + " = " + resultado + "\r\n";  
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtTabuada.Text = "";
        }
    }
}
