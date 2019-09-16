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
    public partial class Exercicio11 : Form
    {
        public Form tela;
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtVal.Text.Equals("")))
            {
                Exer11 exer11 = new Exer11();
                exer11.Val = double.Parse(txtVal.Text);
                exer11.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtVal.Clear();
            //FOCAR NESSE CAMPO
            txtVal.Focus();
        }

        private void Exercicio11_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
