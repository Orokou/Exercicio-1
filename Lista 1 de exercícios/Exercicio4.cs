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
    public partial class telaExercicio4 : Form
    {
        public Form tela;
        public telaExercicio4()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DO CAMPO NÃO ESTIVER EM BRANCO
            if ((!txtValor.Text.Equals("")))
            {
                Exer4 exer4 = new Exer4();
                exer4.Sal = double.Parse(txtValor.Text);
                exer4.Converter();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha o campo Salário!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtValor.Clear();
            //FOCAR NESSE CAMPO
            txtValor.Focus();
        }

        private void TelaExercicio4_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
