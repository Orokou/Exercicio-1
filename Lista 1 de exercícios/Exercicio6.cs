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
    public partial class telaExercicio6 : Form
    {
        public Form tela;
        public telaExercicio6()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtNome.Text.Equals(""))&&(!txtIdade.Text.Equals("")))             
            {
                Exer6 exer6 = new Exer6();
                exer6.Idade = int.Parse(txtIdade.Text);
                exer6.Nome = txtNome.Text;
                exer6.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtNome.Clear();
            txtIdade.Clear();  
            //FOCAR NESSE CAMPO
            txtNome.Focus();
        }

        private void TelaExercicio6_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
