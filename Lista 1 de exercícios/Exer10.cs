using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer10
    {
        double sal, car, carVen, totVen;

        public double Car
        {
            get
            {
                return car;
            }

            set
            {
                car = value;
            }
        }

        public double CarVen
        {
            get
            {
                return carVen;
            }

            set
            {
                carVen = value;
            }
        }

        public double Sal
        {
            get
            {
                return sal;
            }

            set
            {
                sal = value;
            }
        }

        public double TotVen
        {
            get
            {
                return totVen;
            }

            set
            {
                totVen = value;
            }
        }

        public void Calcular()
        {
            Sal = Sal + (Car * CarVen) + (TotVen * 0.05);
            MessageBox.Show("Salário final: " + Sal);
        }
    }
}
