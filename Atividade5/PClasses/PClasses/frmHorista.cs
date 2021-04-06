using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciarHora_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNomeH.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatriculaH.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHoraH.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHorasH.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntradaEmpresaH.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFaltasH.Text);

            MessageBox.Show("Nome:" + objHorista.NomeEmpregado +
                "\n" + "Matrícula:" + objHorista.Matricula + "\n" +
                "Tempo Trabalho" + objHorista.TempoTrabalho().ToString() +
                "\n" + "Salário" + objHorista.SalarioBruto().ToString("N2"));
        }
    }
}
