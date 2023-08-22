using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        private Adicao adicao = new Adicao();
        private Subtracao subtracao = new Subtracao();
        private Multiplicacao multiplicacao = new Multiplicacao();
        private Divisao divisao = new Divisao();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            lblResultado.Text = adicao.PerformAdicao(num1, num2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            lblResultado.Text = subtracao.PerformSubtracao(num1, num2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            lblResultado.Text = multiplicacao.PerformMultiplicacao(num1, num2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            lblResultado.Text = subtracao.PerformSubtracao(num1, num2).ToString();
        }
    }
}
