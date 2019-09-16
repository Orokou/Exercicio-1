using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer8
    {
        //ATRIBUTOS
        double sal, per;

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


        public void Calcular()
        {
            Sal = Sal + Sal * (Per / 100);
            MessageBox.Show("Novo salário: " + Sal);
        }

    }
}
