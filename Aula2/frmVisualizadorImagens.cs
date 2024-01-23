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
    public partial class frmVisualizadorImagens : Form
    {
        public frmVisualizadorImagens()
        {
            InitializeComponent();
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked == true)
            {
                pbImagens.SizeMode = PictureBoxSizeMode.Normal; 
            }
        }

        private void btnMostrarImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagens.ShowDialog() == DialogResult.OK)
            {
                pbImagens.Load(ofdImagens.FileName);
                btnMostrarImagem.Enabled = false; // Desabilita o botão btnMostrar Imagem
            }
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            pbImagens.Image = null; // Limpa a imagem do PictureBox pbImagens
            btnMostrarImagem.Enabled = true; // Habilita o botão btnMostrarImagem
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStretch.Checked == true)
            {
                pbImagens.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
