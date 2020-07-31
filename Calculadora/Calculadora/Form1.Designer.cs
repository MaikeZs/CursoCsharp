namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnseparador = new System.Windows.Forms.Button();
            this.btnMutiplicacao = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnsoma = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnigaul = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(43, 96);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(71, 56);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(43, 43);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(443, 22);
            this.txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calcular";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(120, 96);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 56);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(201, 96);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(73, 56);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(43, 158);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(71, 56);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(120, 158);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 56);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(201, 158);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(73, 56);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(43, 220);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(71, 56);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(120, 220);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 56);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(201, 220);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(73, 56);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(43, 299);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(71, 45);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnseparador
            // 
            this.btnseparador.Location = new System.Drawing.Point(120, 299);
            this.btnseparador.Name = "btnseparador";
            this.btnseparador.Size = new System.Drawing.Size(75, 45);
            this.btnseparador.TabIndex = 12;
            this.btnseparador.Text = ",";
            this.btnseparador.UseVisualStyleBackColor = true;
            this.btnseparador.Click += new System.EventHandler(this.btnseparador_Click);
            // 
            // btnMutiplicacao
            // 
            this.btnMutiplicacao.Location = new System.Drawing.Point(318, 96);
            this.btnMutiplicacao.Name = "btnMutiplicacao";
            this.btnMutiplicacao.Size = new System.Drawing.Size(75, 56);
            this.btnMutiplicacao.TabIndex = 13;
            this.btnMutiplicacao.Text = "*";
            this.btnMutiplicacao.UseVisualStyleBackColor = true;
            this.btnMutiplicacao.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(318, 220);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(75, 56);
            this.btnmenos.TabIndex = 14;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btnsoma
            // 
            this.btnsoma.Location = new System.Drawing.Point(318, 158);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(75, 56);
            this.btnsoma.TabIndex = 15;
            this.btnsoma.Text = "+";
            this.btnsoma.UseVisualStyleBackColor = true;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(318, 288);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(75, 56);
            this.btndividir.TabIndex = 16;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnigaul
            // 
            this.btnigaul.Location = new System.Drawing.Point(201, 299);
            this.btnigaul.Name = "btnigaul";
            this.btnigaul.Size = new System.Drawing.Size(75, 45);
            this.btnigaul.TabIndex = 17;
            this.btnigaul.Text = "=";
            this.btnigaul.UseVisualStyleBackColor = true;
            this.btnigaul.Click += new System.EventHandler(this.btnigaul_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(414, 96);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(101, 37);
            this.btnlimpar.TabIndex = 18;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnigaul);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnsoma);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnMutiplicacao);
            this.Controls.Add(this.btnseparador);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnseparador;
        private System.Windows.Forms.Button btnMutiplicacao;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnigaul;
        private System.Windows.Forms.Button btnlimpar;
    }
}

