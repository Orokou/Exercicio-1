using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer3
    {
        //ATRIBUTOS
        double fah;
        double cel;

        public double Fah
        {
            get
            {
                return fah;
            }

            set
            {
                fah = value;
            }
        }

        public double Cel
        {
            get
            {
                return cel;
            }

            set
            {
                cel = value;
            }
        }

        public void Converter()
        {
            Cel = (Fah - 32) / 1.8;
            MessageBox.Show(Fah + "º Fahrenheit = " + Cel + "º Celsius");
        }
    }
}
