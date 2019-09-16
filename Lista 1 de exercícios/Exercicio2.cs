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
    public partial class telaExercicio2 : Form
    {
        public Form tela;

        public telaExercicio2()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DO CAMPO NÃO ESTIVER EM BRANCO
            if ((!txtValor.Text.Equals("")))
            {
                Exer2 exer2 = new Exer2();
                exer2.Valor = double.Parse(txtValor.Text);
                exer2.Converter();
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

        private void TelaExercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }

        //QUANDO A TELA FECHAR A TELA VOLTARA A TELA ANTERIOR


    }
}
