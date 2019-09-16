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
    public partial class telaExercicio5 : Form
    {
        public Form tela;
        public telaExercicio5()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DO CAMPO NÃO ESTIVER EM BRANCO
            if ((!txtValor.Text.Equals("")))
            {
                Exer5 exer5 = new Exer5();
                exer5.Val = double.Parse(txtValor.Text);
                exer5.Converter();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha o campo Valor!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtValor.Clear();
            //FOCAR NESSE CAMPO
            txtValor.Focus();
        }

        private void Exercicio5_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
