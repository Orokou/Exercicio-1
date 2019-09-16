using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer13
    {
        //ATRIBUTOS
        double pao, broa, total, poupanca;

        public double Broa
        {
            get
            {
                return broa;
            }

            set
            {
                broa = value;
            }
        }

        public double Pao
        {
            get
            {
                return pao;
            }

            set
            {
                pao = value;
            }
        }

        public double Poupanca
        {
            get
            {
                return poupanca;
            }

            set
            {
                poupanca = value;
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
            Pao = Pao * 0.50;
            Broa = Broa * 4.50;
            Total = Pao + Broa;
            Poupanca = Total * 0.10; 
            MessageBox.Show("Você arrecadou: " + Total + "\n" + "Guardar na poupança: " + Poupanca);
        }
    }
}
