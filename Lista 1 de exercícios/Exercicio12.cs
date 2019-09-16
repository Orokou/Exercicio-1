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
    public partial class Exercicio12 : Form
    {
        public Form tela;
        public Exercicio12()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtPre.Text.Equals("")) && (!txtPer.Text.Equals("")))
            {
                Exer12 exer12 = new Exer12();
                exer12.Pre = double.Parse(txtPre.Text);
                exer12.Per = double.Parse(txtPer.Text);
                exer12.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtPre.Clear();
            txtPer.Clear();
            //FOCAR NESSE CAMPO
            txtPre.Focus();
        }

        private void Exercicio12_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
