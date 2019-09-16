using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer4
    {
        //ATRIBUTOS
        double sal;
        double novosal;

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

        public double Novosal
        {
            get
            {
                return novosal;
            }

            set
            {
                novosal = value;
            }
        }

        public void Converter()
        {
            Novosal = Sal + Sal * 0.6;
            MessageBox.Show("Novo salário: " + Novosal);
        }
    }
}
