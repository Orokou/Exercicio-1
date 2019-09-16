using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer9
    {
        //ATRIBUTOS
        double valor;

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
            Valor = Valor + (Valor * 0.28) + (Valor * 0.45);
            MessageBox.Show("Custo final do veículo: " + Valor);
        }
    }
}
