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
    public partial class Lojas_Cadastradas : Form
    {
        Cadastro novo = new Cadastro();
        
        public Lojas_Cadastradas()
        {
            InitializeComponent();

            
            string[,] dado = new string[20, 3];
            dado = Cadastro.dados;
            string nome = " ";
            string local = " ";
            string cat = " ";
            for (int s = 0; s < 3; s++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (x == 0)
                        nome = nome + "\n" + dado[s, 0];
                    else
                        if (x == 1)
                            cat = cat +"\n"+ dado[s, 1];
                        else
                            local = local +"\n" + dado[s, 2];



                }

            }

          lblN.Text= nome;
          lblL.Text = local;
          lblT.Text = cat;

        }

        private void Lojas_Cadastradas_Load(object sender, EventArgs e)
        {
           
           

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
