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
    public partial class telaExercicio7 : Form
    {
        public Form tela;
        public telaExercicio7()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtNulo.Text.Equals("")) && (!txtBranco.Text.Equals("")) && (!txtValido.Text.Equals("")))
            {
                Exer7 exer7 = new Exer7();
                exer7.Nulo = double.Parse(txtNulo.Text);
                exer7.Branco = double.Parse(txtBranco.Text);
                exer7.Valido = double.Parse(txtValido.Text);
                exer7.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtNulo.Clear();
            txtBranco.Clear();
            txtValido.Clear();
            //FOCAR NESSE CAMPO
            txtBranco.Focus();
        }

        private void TelaExercicio7_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
