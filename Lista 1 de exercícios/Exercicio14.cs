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
    public partial class Exercicio14 : Form
    {
        public Form tela;
        public Exercicio14()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtValor.Text.Equals("")) && (!txtGasolina.Text.Equals("")))
            {
                Exer14 exer14 = new Exer14();
                exer14.Valor = double.Parse(txtValor.Text);
                exer14.Gasolina = double.Parse(txtGasolina.Text);
                exer14.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtValor.Clear();
            txtGasolina.Clear();
            //FOCAR NESSE CAMPO
            txtValor.Focus();
        }

        private void Exercicio14_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
