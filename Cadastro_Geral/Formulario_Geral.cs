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
    public partial class Formulario_Geral : Form
    {
        public Formulario_Geral()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cadastro_Clientes formulario = new Cadastro_Clientes();
            formulario.ShowDialog();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Animais formulario = new Cadastro_Animais();
            formulario.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remédios formulario = new Remédios();
            formulario.ShowDialog();
        }

        private void itensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Itens formulario = new Itens();
            formulario.ShowDialog();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            veiculos formulario = new veiculos();
            formulario.ShowDialog();
        }

        private void roupasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roupas formulario = new Roupas();
            formulario.ShowDialog();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bebida formulario = new Bebida();
            formulario.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
