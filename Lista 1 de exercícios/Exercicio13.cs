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
    public partial class Exercicio13 : Form
    {
        public Form tela;
        public Exercicio13()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtPao.Text.Equals("")) && (!txtBroa.Text.Equals("")))
            {
                Exer13 exer13 = new Exer13();
                exer13.Pao = double.Parse(txtPao.Text);
                exer13.Broa = double.Parse(txtBroa.Text);
                exer13.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtPao.Clear();
            txtBroa.Clear();
            //FOCAR NESSE CAMPO
            txtPao.Focus();
        }

        private void Exercicio13_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
