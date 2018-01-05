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
    public partial class Cadastro : Form
    {


        public static string[,] dados = new string[20, 3];
        public static int qtd_lojas = 0;
        string[] nomes = new string[20];
        string[] catego = new string[20];
        string[] local = new string[20];
        
        public Cadastro()
        {
            //Lojas_Cadastradas novo = new Lojas_Cadastradas();
            InitializeComponent();
            //Lojas_Cadastradas nova = new Lojas_Cadastradas();
            //Lojas_Cadastradas.
            //novo.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EnvioLojas_Click(object sender, EventArgs e)
        {
            
                //nomes[i] = txtNome.Text;
                //catego[i] = cmbCat.Text;
                //local[i] = cmbLoc.Text;

            if ((txtNome.Text != "") && (cmbCat.Text != "") && (cmbLoc.Text != ""))
                {
                    nomes[qtd_lojas] = txtNome.Text;
                    catego[qtd_lojas] = cmbCat.Text;
                    local[qtd_lojas] = cmbLoc.Text;
                   
                    if (qtd_lojas == 19)
                    {
                        Processamento novo = new Processamento();

                        dados = novo.dados(nomes, catego, local);
                        MessageBox.Show("Lojas cadastradas com sucesso!");
                        this.Close();
                    }
                    qtd_lojas++;
                    txtNome.Clear();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnTermina_Click(object sender, EventArgs e)
        {

            Processamento novo = new Processamento();

            dados = novo.dados(nomes, catego, local);
            MessageBox.Show("Lojas cadastradas com sucesso!");
            this.Close();
        }
    }
}
