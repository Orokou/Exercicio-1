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
    public partial class Exercicio8 : Form
    {
        public Form tela;
        public Exercicio8()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtSal.Text.Equals("")) && (!txtPer.Text.Equals("")))
            {
                Exer8 exer8 = new Exer8();
                exer8.Sal = double.Parse(txtSal.Text);
                exer8.Per = double.Parse(txtPer.Text);
                exer8.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtSal.Clear();
            txtPer.Clear();
            //FOCAR NESSE CAMPO
            txtSal.Focus();
        }

        private void Exercicio8_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
