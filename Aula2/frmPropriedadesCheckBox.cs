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
    public partial class frmPropriedadesCheckBox : Form
    {
        public frmPropriedadesCheckBox()
        {
            InitializeComponent();
        }

        // Evento que verifica se o CheckBox está marcado ou desmarcado

        private void pessoaFisica_CheckStateChanged(object sender, EventArgs e)
        {
            if (pessoaFisica.Checked == true)
            {
                gpPessoaFisica.Visible = true;
            }
            else
            {
               gpPessoaFisica.Visible = false;
            }
        }

        private void pessoaJuridica_CheckStateChanged(object sender, EventArgs e)
        {
            if (pessoaJuridica.Checked == true)
            {
                gpPessoaJuridica.Visible = true;
            }
            else
            {
                gpPessoaJuridica.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
