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
   
 public partial class Exercicio10 : Form
    {
        public Form tela;
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            //SE O VALOR DOS CAMPOS NÃO ESTIVER EM BRANCO
            if ((!txtSal.Text.Equals("")) && (!txtCar.Text.Equals("")) && (!txtCarVen.Text.Equals("")) && (!txtTotVen.Text.Equals("")))
            {
                Exer10 exer10 = new Exer10();
                exer10.Sal = double.Parse(txtSal.Text);
                exer10.Car = double.Parse(txtCar.Text);
                exer10.CarVen = double.Parse(txtCarVen.Text);
                exer10.TotVen = double.Parse(txtTotVen.Text);
                exer10.Calcular();
            }

            //SE O VALOR DE TXTVALOR ESTIVER EM BRANCO
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            //LIMPAR O CAMPO DE MENSAGEM
            txtSal.Clear();
            txtCar.Clear();
            txtCarVen.Clear();
            txtTotVen.Clear();
            //FOCAR NESSE CAMPO
            txtSal.Focus();
        }

        private void Exercicio10_FormClosed(object sender, FormClosedEventArgs e)
        {
            tela.Show();
        }
    }
}
