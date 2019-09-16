using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer7
    {
        //ATRIBUTOS
        double nulo;
        double branco;
        double valido;
        double total;

        public double Nulo
        {
            get
            {
                return nulo;
            }

            set
            {
                nulo = value;
            }
        }

        public double Branco
        {
            get
            {
                return branco;
            }

            set
            {
                branco = value;
            }
        }

        public double Valido
        {
            get
            {
                return valido;
            }

            set
            {
                valido = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public void Calcular()
        {
            Total = Nulo + Branco + Valido;
            Nulo = 100 * (Nulo / Total);
            Branco = 100 * (Branco / Total);
            Valido = 100 * (Valido / Total);
            MessageBox.Show("Total de votos: " + Total + "\n" + "Votos Válidos: " + Valido + "%" + "\n" + "Votos em Branco: " + Branco + "%" + "\n" + "Votos Nulos: " + Nulo + "%"); 
        }
    }
}
