using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1_de_exercícios
{
    public partial class Exercicio15 : Form
    {
        public Form tela;

        public Exercicio15()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtValor1.Text.Equals("")) && (!txtValor2.Text.Equals("")))
            {
                Exer15 exer15 = new Exer15();
                exer15.Valor1 = int.Parse(txtValor1.Text);
                exer15.Valor2 = int.Parse(txtValor2.Text);
                exer15.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtValor1.Clear();
            txtValor2.Clear();
            //FOCAR NESSE CAMPO
            txtValor1.Focus();
        }

        private void Exercicio15_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
