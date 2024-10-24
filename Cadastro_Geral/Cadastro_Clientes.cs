using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Geral
{
    public partial class Cadastro_Clientes : Form
    {
        public Cadastro_Clientes()
        {
            InitializeComponent();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
