using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE2
{
    public partial class Form1 : Form
    {
        double peso, altura, resultado;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskAltura.Clear();
            mskPeso.Clear();
            mskAltura.Focus();
       
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(mskAltura.Text, out altura) || !double.TryParse(mskPeso.Text, out peso))
            {
                MessageBox.Show("Valores Inválidos!");
            }
            else
            {
                if (rdbFeminino.Checked)
                {
                    resultado = (62.1 * altura) - 44.7;
                    resultado = Math.Round(resultado, 2);

                    if (resultado == peso)
                    {
                        MessageBox.Show("Você está no seu peso ideal! Talvez não esteja aproveitando sua vida...");
                    }
                    else if (peso > resultado)
                    {
                        MessageBox.Show("Você está gordona, procure diminuir na fritura!");
                    }
                    else
                    {
                        MessageBox.Show("Você está magrinha, use pedras no bolso para não ser levada com o vento!");
                    }
                }

                    if (rdbMasculino.Checked)
                    {
                        resultado = (72.7 * altura) - 58;
                        resultado = Math.Round(resultado, 2);

                    if (resultado == peso)
                        {
                            MessageBox.Show("Você está no seu peso ideal! Talvez não esteja aproveitando sua vida...");
                        }
                        else if (peso > resultado)
                        {
                            MessageBox.Show("Você está gordão, procure diminuir na fritura!");
                        }
                        else
                        {
                            MessageBox.Show("Você está magrinho, use pedras no bolso para não ser levado com o vento!");
                        }

                    }

                
            }
        }
    }
}
