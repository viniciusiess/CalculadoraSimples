﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text)).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNum1.Text) - float.Parse(txtNum2.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNum1.Text) * float.Parse(txtNum2.Text)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (float.Parse(txtNum1.Text) / float.Parse(txtNum2.Text)).ToString();
        }
    }
}
