namespace Lista_1_de_exercícios
{
    partial class Exercicio13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPao = new System.Windows.Forms.TextBox();
            this.txtBroa = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "R$ 4,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "quantidade de broas a cada dia. Cada pãozinho custa R$ 0,50 e a broa custa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "13. A padaria Hotpão vende uma certa quantidade de pães franceses e uma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Com base nestes fatos, faça um programa para ler as quantidades de pães e";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(370, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "do total arrecadado). Você foi contratado para fazer os cálculos para o dono.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "pães e broas (juntos), e quanto deve guardar numa conta de poupança (10%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "de broas, e depois calcular os dados solicitados.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Pães vendidos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Broas vendidas:";
            // 
            // txtPao
            // 
            this.txtPao.Location = new System.Drawing.Point(193, 259);
            this.txtPao.Name = "txtPao";
            this.txtPao.Size = new System.Drawing.Size(100, 20);
            this.txtPao.TabIndex = 49;
            // 
            // txtBroa
            // 
            this.txtBroa.Location = new System.Drawing.Point(193, 300);
            this.txtBroa.Name = "txtBroa";
            this.txtBroa.Size = new System.Drawing.Size(100, 20);
            this.txtBroa.TabIndex = 50;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(193, 357);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 23);
            this.btnConvert.TabIndex = 51;
            this.btnConvert.Text = "Calcular";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Exercicio13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBroa);
            this.Controls.Add(this.txtPao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Exercicio13";
            this.Text = "Exercicio13";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exercicio13_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPao;
        private System.Windows.Forms.TextBox txtBroa;
        private System.Windows.Forms.Button btnConvert;
    }
}