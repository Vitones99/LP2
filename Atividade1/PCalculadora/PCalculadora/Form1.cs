using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out num1) || !double.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("Valores Inválidos");

            else
            {
                resultado = num1 - num2;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
                if (num2==0)
                {
                    MessageBox.Show("Não é possível dividir por zero");
                }
            else
            {
                resultado = num1 / num2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out num1) || !double.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("Valores Inválidos");

            else
            {
                resultado = num1 * num2;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out num1) || !double.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("Valores Inválidos");

            else
            {
                resultado = num1 + num2;
                txtResultado.Text = resultado.ToString("N2");
            }
        }

    }
}
