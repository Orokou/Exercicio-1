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
    public partial class telaExercicio1 : Form
    {
        public Form tela;

        public telaExercicio1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DE TXTVALOR NÃO ESTIVER EM BRANCO
            if ((!txtValor.Text.Equals("")))
            {
                Exer1 exer1 = new Exer1();
                exer1.Valor = double.Parse(txtValor.Text);
                exer1.Converter();
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

        //QUANDO A TELA FECHAR A TELA VOLTARA A TELA ANTERIOR
        private void TelaExercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
