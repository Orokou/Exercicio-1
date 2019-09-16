using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer12
    {
        //ATRIBUTOS
        double pre, per;

        public double Per
        {
            get
            {
                return per;
            }

            set
            {
                per = value;
            }
        }

        public double Pre
        {
            get
            {
                return pre;
            }

            set
            {
                pre = value;
            }
        }

        public void Calcular()
        {
            Pre = Pre + Pre * (Per / 100);
            MessageBox.Show("Valor de venda: " + Pre);
        }
    }
}
