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
    public partial class Exercicio9 : Form
    {
        public Form tela;
        public Exercicio9()
        {
            InitializeComponent();
        }

        private void Exercicio9_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtVal.Text.Equals("")))
            {
                Exer9 exer9 = new Exer9();
                exer9.Valor = double.Parse(txtVal.Text);
                exer9.Calcular();
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
    }
}
