using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lista_1_de_exercícios
{
    class Exer15
    {
        //ATRIBUTOS
        int valor1, valor2;

        public int Valor1
        {
            get
            {
                return valor1;
            }

            set
            {
                valor1 = value;
            }
        }

        public int Valor2
        {
            get
            {
                return valor2;
            }

            set
            {
                valor2 = value;
            }
        }

        public void Calcular()
        {
            if(valor1 == valor2)
            {
                MessageBox.Show("Esse é seu par perfeito");
            }

            else 
            {
                MessageBox.Show("Afaste-se do seu inimigo");
            }
        }

    }
}
