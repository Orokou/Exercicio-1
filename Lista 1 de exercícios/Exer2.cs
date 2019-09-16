using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer2
    {
        //ATRIBUTOS
        double valor;
        double valorconv;

        //GETTERS E SETTERS
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


        //CONVERTER
        public void Converter()
        {
            Valorconv = Valor * 4.09;
            if (Valorconv > 99 && Valorconv < 200)
            {
                MessageBox.Show("Vou comprar bitcoin");
            }

            else if (Valorconv > 199)
            {
                MessageBox.Show("Vou investir no tesouro nacional");
            }

            else if (Valorconv < 100)
            {
                MessageBox.Show("Vou comprar bala");
            }
        }
    }
}
