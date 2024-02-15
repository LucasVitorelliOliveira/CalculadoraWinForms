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
        private Operacao opSelect { get; set; }
        private decimal valor, resultado;
        enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisiao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            label1.Text = "";
            valor = 0; 
            resultado = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBox.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBox.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBox.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBox.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBox.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBox.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtBox.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtBox.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtBox.Text += "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opSelect = Operacao.Adicao;
            valor = Convert.ToDecimal(txtBox.Text);
            txtBox.Text = "";
            label1.Text = "+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            opSelect = Operacao.Subtracao;
            valor = Convert.ToDecimal(txtBox.Text);
            txtBox.Text = "";
            label1.Text = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            opSelect = Operacao.Divisiao;
            valor = Convert.ToDecimal(txtBox.Text);
            txtBox.Text = "";
            label1.Text = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            opSelect = Operacao.Multiplicacao;
            valor = Convert.ToDecimal(txtBox.Text);
            txtBox.Text = "";
            label1.Text = "x";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            switch (opSelect)
            {
                case Operacao.Adicao:
                    resultado = valor + Convert.ToDecimal(txtBox.Text);
                    break;
                case Operacao.Subtracao:
                    resultado = valor - Convert.ToDecimal(txtBox.Text);
                    break;
                case Operacao.Divisiao:
                    resultado = valor / Convert.ToDecimal(txtBox.Text);
                    break;
                case Operacao.Multiplicacao:
                    resultado = valor * Convert.ToDecimal(txtBox.Text);
                    break;
            }
            txtBox.Text = resultado.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(!txtBox.Text.Contains(","))
                txtBox.Text += ",";
        }
    }
}
