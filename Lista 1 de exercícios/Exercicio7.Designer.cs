namespace Lista_1_de_exercícios
{
    partial class telaExercicio7
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBranco = new System.Windows.Forms.TextBox();
            this.txtNulo = new System.Windows.Forms.TextBox();
            this.txtValido = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "que cada um representa em relação ao total de eleitores.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "o número de votos brancos, nulos e válidos. Calcular e escrever o percentual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "7. Escreva um programa para ler o número total de eleitores de um município,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Votos em branco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Votos nulos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Votos válidos:";
            // 
            // txtBranco
            // 
            this.txtBranco.Location = new System.Drawing.Point(240, 258);
            this.txtBranco.Name = "txtBranco";
            this.txtBranco.Size = new System.Drawing.Size(100, 20);
            this.txtBranco.TabIndex = 22;
            // 
            // txtNulo
            // 
            this.txtNulo.Location = new System.Drawing.Point(215, 294);
            this.txtNulo.Name = "txtNulo";
            this.txtNulo.Size = new System.Drawing.Size(100, 20);
            this.txtNulo.TabIndex = 23;
            // 
            // txtValido
            // 
            this.txtValido.Location = new System.Drawing.Point(223, 332);
            this.txtValido.Name = "txtValido";
            this.txtValido.Size = new System.Drawing.Size(100, 20);
            this.txtValido.TabIndex = 24;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(223, 389);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 23);
            this.btnConvert.TabIndex = 25;
            this.btnConvert.Text = "Calcular";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // telaExercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtValido);
            this.Controls.Add(this.txtNulo);
            this.Controls.Add(this.txtBranco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "telaExercicio7";
            this.Text = "Exercicio7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaExercicio7_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBranco;
        private System.Windows.Forms.TextBox txtNulo;
        private System.Windows.Forms.TextBox txtValido;
        private System.Windows.Forms.Button btnConvert;
    }
}