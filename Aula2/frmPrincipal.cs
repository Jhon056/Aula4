using Aula2;
using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Olá, escolha uma opção!"; // A Label lblMensagem exige um texto
            lblMensagem.ForeColor = Color.Red; // E a cor do mesmo é definida como azul royal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPropriedadesCheckBox propriedades = new frmPropriedadesCheckBox(); // Instanciando o formulário
            propriedades.ShowDialog(); // O formulário é exibido através do método ShowDialog
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            frmVisualizadorImagens visualizador = new frmVisualizadorImagens();
            visualizador.ShowDialog();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            frmTabuada tabuada = new frmTabuada();
            tabuada.ShowDialog();
        }
    }
}
