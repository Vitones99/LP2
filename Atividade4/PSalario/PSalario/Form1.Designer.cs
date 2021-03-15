
namespace PSalario
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
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.btnVerificarDescontos = new System.Windows.Forms.Button();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIR = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIR = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIR = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIR = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.rbtmMasc = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.cmbNumeroFilhos = new System.Windows.Forms.ComboBox();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(24, 44);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(108, 13);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome do Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(24, 98);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.Location = new System.Drawing.Point(24, 155);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblNumeroFilhos.TabIndex = 2;
            this.lblNumeroFilhos.Text = "Número de Filhos";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(138, 41);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(339, 20);
            this.txtNomeFuncionario.TabIndex = 3;
            // 
            // btnVerificarDescontos
            // 
            this.btnVerificarDescontos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerificarDescontos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerificarDescontos.Location = new System.Drawing.Point(174, 221);
            this.btnVerificarDescontos.Name = "btnVerificarDescontos";
            this.btnVerificarDescontos.Size = new System.Drawing.Size(159, 50);
            this.btnVerificarDescontos.TabIndex = 6;
            this.btnVerificarDescontos.Text = "Verificar Descontos";
            this.btnVerificarDescontos.UseVisualStyleBackColor = false;
            this.btnVerificarDescontos.Click += new System.EventHandler(this.btnVerificarDescontos_Click);
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(24, 367);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(75, 13);
            this.lblAliquotaINSS.TabIndex = 7;
            this.lblAliquotaINSS.Text = "Alíquota INSS";
            // 
            // lblAliquotaIR
            // 
            this.lblAliquotaIR.AutoSize = true;
            this.lblAliquotaIR.Location = new System.Drawing.Point(24, 406);
            this.lblAliquotaIR.Name = "lblAliquotaIR";
            this.lblAliquotaIR.Size = new System.Drawing.Size(61, 13);
            this.lblAliquotaIR.TabIndex = 8;
            this.lblAliquotaIR.Text = "Alíquota IR";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(24, 446);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioFamilia.TabIndex = 9;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(24, 485);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioLiquido.TabIndex = 10;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(266, 367);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 11;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIR
            // 
            this.lblDescontoIR.AutoSize = true;
            this.lblDescontoIR.Location = new System.Drawing.Point(266, 406);
            this.lblDescontoIR.Name = "lblDescontoIR";
            this.lblDescontoIR.Size = new System.Drawing.Size(67, 13);
            this.lblDescontoIR.TabIndex = 12;
            this.lblDescontoIR.Text = "Desconto IR";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(138, 364);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(109, 20);
            this.txtAliquotaINSS.TabIndex = 13;
            // 
            // txtAliquotaIR
            // 
            this.txtAliquotaIR.Enabled = false;
            this.txtAliquotaIR.Location = new System.Drawing.Point(138, 403);
            this.txtAliquotaIR.Name = "txtAliquotaIR";
            this.txtAliquotaIR.Size = new System.Drawing.Size(109, 20);
            this.txtAliquotaIR.TabIndex = 14;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(138, 443);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(109, 20);
            this.txtSalarioFamilia.TabIndex = 15;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(138, 482);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(109, 20);
            this.txtSalarioLiquido.TabIndex = 16;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(372, 364);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(109, 20);
            this.txtDescontoINSS.TabIndex = 17;
            // 
            // txtDescontoIR
            // 
            this.txtDescontoIR.Enabled = false;
            this.txtDescontoIR.Location = new System.Drawing.Point(372, 403);
            this.txtDescontoIR.Name = "txtDescontoIR";
            this.txtDescontoIR.Size = new System.Drawing.Size(109, 20);
            this.txtDescontoIR.TabIndex = 18;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(29, 30);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 19;
            this.lblMensagem.Visible = false;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtnFem);
            this.gpbSexo.Controls.Add(this.rbtmMasc);
            this.gpbSexo.Location = new System.Drawing.Point(306, 78);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(171, 90);
            this.gpbSexo.TabIndex = 20;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(22, 56);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(67, 17);
            this.rbtnFem.TabIndex = 1;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // rbtmMasc
            // 
            this.rbtmMasc.AutoSize = true;
            this.rbtmMasc.Checked = true;
            this.rbtmMasc.Location = new System.Drawing.Point(22, 33);
            this.rbtmMasc.Name = "rbtmMasc";
            this.rbtmMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtmMasc.TabIndex = 0;
            this.rbtmMasc.TabStop = true;
            this.rbtmMasc.Text = "Masculino";
            this.rbtmMasc.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(328, 185);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(62, 17);
            this.ckbxCasado.TabIndex = 21;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // cmbNumeroFilhos
            // 
            this.cmbNumeroFilhos.FormattingEnabled = true;
            this.cmbNumeroFilhos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cmbNumeroFilhos.Location = new System.Drawing.Point(138, 149);
            this.cmbNumeroFilhos.Name = "cmbNumeroFilhos";
            this.cmbNumeroFilhos.Size = new System.Drawing.Size(62, 21);
            this.cmbNumeroFilhos.TabIndex = 23;
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(138, 95);
            this.mskbxSalarioBruto.Mask = "00000.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(78, 20);
            this.mskbxSalarioBruto.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMensagem);
            this.groupBox1.Location = new System.Drawing.Point(37, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 64);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suas Características";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(503, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.cmbNumeroFilhos);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.txtDescontoIR);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIR);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblDescontoIR);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIR);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.btnVerificarDescontos);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Button btnVerificarDescontos;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIR;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIR;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIR;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIR;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.RadioButton rbtmMasc;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.ComboBox cmbNumeroFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

