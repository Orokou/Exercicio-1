using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer11
    {
        double val;

        public double Val
        {
            get
            {
                return val;
            }

            set
            {
                val = value;
            }
        }

        public void Calcular()
        {
            Val = Val / 5;
            MessageBox.Show("5 Prestações de " + Val + " R$");
        }
    }
}
