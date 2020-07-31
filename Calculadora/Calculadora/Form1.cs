using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double valorArmazenado;
        double valorEmTela;
        char operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.Text += 2;
            getTextValue();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valorArmazenado = valorEmTela;
            valorEmTela = 0;
            operador = '/';
            txt.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valorArmazenado = valorEmTela;
            valorEmTela = 0;
            operador = '*';
            txt.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt.Text += 1;
            getTextValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            valorEmTela = 0;
            valorArmazenado = 0;
        }

        private void getTextValue()
        {
            valorEmTela = Convert.ToDouble(txt.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt.Text += 3;
            getTextValue();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt.Text += 4;
            getTextValue();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt.Text += 5;
            getTextValue();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt.Text += 6;
            getTextValue();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt.Text += 7;
            getTextValue();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt.Text+=8;
            getTextValue();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt.Text += 9;
            getTextValue();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt.Text += 0;
            getTextValue();
        }

        private void btnseparador_Click(object sender, EventArgs e)
        {
            txt.Text += ",";
            getTextValue();
        }

        private void btnigaul_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            switch (operador) 
            {
                case '+':
                    txt.Text = (valorEmTela + valorArmazenado)+"";
                    break;
                case '-':
                    txt.Text = (valorArmazenado - valorEmTela ) + "";
                    break;
                case '*':
                    txt.Text = (valorArmazenado * valorEmTela) + "";
                    break;
                case '/':
                    txt.Text = (valorArmazenado / valorEmTela) + "";
                    break;
            }
            valorArmazenado = 0;
            valorEmTela = 0;
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            valorArmazenado = valorEmTela;
            valorEmTela = 0;
            operador = '+';
            txt.Text = "";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            valorArmazenado = valorEmTela;
            valorEmTela = 0;
             operador='-';
            txt.Text = "";
        }
    }
}
