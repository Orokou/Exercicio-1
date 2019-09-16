using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer1
    {
        //ATRIBUTOS
        double valorconv;
        double valor;

        //GETTERS E SETTERS
        public double Valorconv
        {
            get
            {
                return valorconv;
            }

            set
            {
                valorconv = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }



        //Converter
        public void Converter()
        {
            valorconv = Valor * 4.09;
            if (Valor >= 2 && valorconv >= 2)
            {
                MessageBox.Show(Valor + " Reais = " + valorconv.ToString() + " Dólares");
            }

            else if (Valor >= 2 && valorconv < 2)
            {
                MessageBox.Show(Valor + " Reais = " + valorconv.ToString() + " Dólar");
            }

            else if (Valor < 2 && valorconv >= 2)
            {
                MessageBox.Show(Valor + " Real = " + valorconv.ToString() + " Dólares");
            }

            else if (Valor < 2 && valorconv < 2)
            {
                MessageBox.Show(Valor + " Real = " + valorconv.ToString() + " Dólar");
            }
        }
    }
}
