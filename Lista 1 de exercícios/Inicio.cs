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
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            telaExercicio1 tela = new telaExercicio1 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            telaExercicio2 tela = new telaExercicio2 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            telaExercicio3 tela = new telaExercicio3 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            telaExercicio4 tela = new telaExercicio4 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            telaExercicio5 tela = new telaExercicio5 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            telaExercicio6 tela = new telaExercicio6 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            telaExercicio7 tela = new telaExercicio7 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Exercicio8 tela = new Exercicio8 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Exercicio9 tela = new Exercicio9 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            Exercicio10 tela = new Exercicio10 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            Exercicio11 tela = new Exercicio11 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            Exercicio12 tela = new Exercicio12 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            Exercicio13 tela = new Exercicio13 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            Exercicio14 tela = new Exercicio14 { tela = this };
            this.Hide();
            tela.Show();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Exercicio15 tela = new Exercicio15 { tela = this };
            this.Hide();
            tela.Show();
        }
    }
}
