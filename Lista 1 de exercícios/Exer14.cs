using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer14
    {
        //ATRIBUTOS
        double valor, gasolina;

        public double Gasolina
        {
            get
            {
                return gasolina;
            }

            set
            {
                gasolina = value;
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

        public void Calcular()
        {
            Valor = Valor / Gasolina;
            MessageBox.Show("Você colocou: " + Valor + " litros no tanque!");
        }
    }
}
