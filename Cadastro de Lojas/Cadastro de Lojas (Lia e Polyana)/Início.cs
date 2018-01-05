using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Lojas__Lia_e_Polyana_
{
    public partial class Início : Form
    {
        public Início()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void lojasCadastradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cadastro = new Cadastro();
            Cadastro.Show();
            
        }

        private void visualizarLojasCadastradasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form Lojas_Cadastradas = new Lojas_Cadastradas();
            Lojas_Cadastradas.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Busca = new Busca();
            Busca.Show();
        }
    }
}


