using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Lojas__Lia_e_Polyana_
{
    class Processamento
    {
        public string[,] dados(string[] nomes, string[] tipo, string[] local)
        {
            string[,] retorno = new string[20,3];
            int n=0;
            int t=0;
            int l=0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        retorno[i, 0] = nomes[n];
                        n++;

                    }
                    else
                        if (j == 1)
                        {
                            retorno[i, 1] = tipo[t];
                            t++;

                        }
                        else
                        {
                            retorno[i, 2] = local[l];
                            l++;
                        }

                    
                   
                }
                
            }
            
            
            return retorno;
        }

        public string busca (string[,]dados, string loja)
    {
        string numero = " ";

            for (int i = 0; i < 20; i++)
            {
                if (dados[i, 0] == loja)
                {
                    //numero = Convert.ToString(i+43);
                    numero = dados[i, 2].Substring(5, 2);
                }

            }

            return numero;

    }
        public string tipo(string[,] dados,string loja)
        {
            string retorno = "";

            for (int i = 0; i < 20; i++)
            {
                if (dados[i, 0] == loja)
                {
                    retorno = dados[i, 1];
                }
            }
            return retorno;

        }

    }
}
