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
    public partial class Busca : Form
    {

        Cadastro cadastro = new Cadastro();
        public static string[,] dado = new string[20, 3];
        
       
       
        public Busca()
        {
          
            InitializeComponent();
            
            dado = Cadastro.dados;
            int qtd_lojas = Cadastro.qtd_lojas;

            for (int j = 0; j < qtd_lojas; j++)
            {
                cmbBusca.Items.Add(dado[j, 0]);
            } 
          
            
        }

        private void Busca_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            string aplicacao = Application.StartupPath;
           
            
            Processamento process = new Processamento();
            string loja = cmbBusca.Text;
            string numero_loja = process.busca(dado, loja);
            string tipo = process.tipo(dado, loja);
            string arquivo = aplicacao + "\\shoppingimgs\\" + numero_loja + ".png";
            pictureBox1.ImageLocation = arquivo;
            lblDados.Text = "Loja: " + loja + "\nLocalização: " + numero_loja + "\nTipo: "+ tipo;           
        }

        private void cmbBusca_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

        

        }
    }

