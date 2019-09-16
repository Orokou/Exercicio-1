using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer5
    {
        //ATRIBUTOS
        double val;
        double novoval;

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

        public double Novoval
        {
            get
            {
                return novoval;
            }

            set
            {
                novoval = value;
            }
        }

        public void Converter()
        {
            Novoval = Val + Val * 0.049;
            MessageBox.Show("Valor com rendimento após um mês: " + Novoval);
        }
    }
}
