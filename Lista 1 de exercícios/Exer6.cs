using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    class Exer6
    {
        //ATRIBUTOS
        string nome;
        int idade;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        //GETTERS E SETTERS

        public void Calcular()
        {
            Idade = Idade * 365;
            MessageBox.Show(Nome + " , você já viveu " + Idade + " dias");
        }
    }
}
