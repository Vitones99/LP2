using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarDescontos_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;
            double salarioBruto = 0;

            if ((txtNomeFuncionario.Text == "") || (txtNomeFuncionario.Text.Length < 3))
                MessageBox.Show("Nome Inválido!");
            else if (!double.TryParse(mskbxSalarioBruto.Text, out salarioBruto))
                MessageBox.Show("Salário Inválido!");
            else
            {
                double descontoInss = 0;
                double descontoIr = 0;
                double salarioFamilia = 0;
                double salarioLiquido = 0;

                if (salarioBruto<=800.47)
                {
                    txtAliquotaINSS.Text = "7.65%";
                    descontoInss = 0.0765 * salarioBruto;
                   
                }
            else if (salarioBruto<=1050)
                {
                    txtAliquotaINSS.Text = "8.65%";
                    descontoInss = 0.0865 * salarioBruto;
                    
                }
            else if (salarioBruto<=1400.77)
                {
                    txtAliquotaINSS.Text = "9%";
                    descontoInss = 0.09 * salarioBruto;
                   
                }
            else if (salarioBruto <=2801.56)
                {
                    txtAliquotaINSS.Text = "11%";
                    descontoInss = 0.11 * salarioBruto;
                   
                }
            else if (salarioBruto > 2801.56)
                {
                    descontoInss = 308.17;
                    txtAliquotaINSS.Text = "Teto";
                }

            txtDescontoINSS.Text = descontoInss.ToString("N2");


                if (salarioBruto <= 1275.12)
                {
                    txtAliquotaIR.Text = "Isento";
                    txtDescontoIR.Text = "Isento";
                }
            else if (salarioBruto <= 2512.08)
                {
                    txtAliquotaIR.Text = "15%";
                    descontoIr = 0.15 * salarioBruto;
                    
                }
            else if (salarioBruto > 2512.08)
                {
                    txtAliquotaIR.Text = "27.5";
                    descontoIr = 0.275 * salarioBruto;
                    
                }
            txtDescontoIR.Text = descontoIr.ToString("N2");


                if (salarioBruto <= 435.32)
                {
                    salarioFamilia = Convert.ToDouble(cmbNumeroFilhos.SelectedItem) * 22.33;
                    txtSalarioFamilia.Text = salarioFamilia.ToString();
                }
            else if (salarioBruto <= 654.61)
                {
                    salarioFamilia = Convert.ToDouble(cmbNumeroFilhos.SelectedItem) * 15.74;
                    txtSalarioFamilia.Text = salarioFamilia.ToString();
                }
            else 
                {
                    salarioFamilia = 0;
                    txtSalarioFamilia.Text = "Não possui benefício";
                }

            txtSalarioFamilia.Text = salarioFamilia.ToString("N2");

            salarioLiquido = salarioBruto - descontoInss - descontoIr + salarioFamilia;
            txtSalarioLiquido.Text = salarioLiquido.ToString("N2");

                string texto = "Os descontos do Salário";

                if (rbtnFem.Checked)
                    texto = texto + " da Sra.";
                else
                    texto = texto + " do Sr.";

                if (ckbxCasado.Checked)
                    texto = texto + " que é casado(a)";
                else
                    texto = texto + " que é solteiro(a)";

                texto = texto + " e que tem " + cmbNumeroFilhos.SelectedItem.ToString() + " Filho(s).";

                lblMensagem.Text = texto;

            }
        }
    }
}
