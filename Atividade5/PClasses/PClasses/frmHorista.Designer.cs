
namespace PClasses
{
    partial class frmHorista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatriculaH = new System.Windows.Forms.TextBox();
            this.txtNomeH = new System.Windows.Forms.TextBox();
            this.txtSalarioHoraH = new System.Windows.Forms.TextBox();
            this.txtNumeroHorasH = new System.Windows.Forms.TextBox();
            this.txtDataEntradaEmpresaH = new System.Windows.Forms.TextBox();
            this.txtDiasFaltasH = new System.Windows.Forms.TextBox();
            this.btnInstanciarHora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário por Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Entrada na Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dias de Faltas";
            // 
            // txtMatriculaH
            // 
            this.txtMatriculaH.Location = new System.Drawing.Point(168, 55);
            this.txtMatriculaH.Name = "txtMatriculaH";
            this.txtMatriculaH.Size = new System.Drawing.Size(108, 20);
            this.txtMatriculaH.TabIndex = 6;
            // 
            // txtNomeH
            // 
            this.txtNomeH.Location = new System.Drawing.Point(168, 83);
            this.txtNomeH.Name = "txtNomeH";
            this.txtNomeH.Size = new System.Drawing.Size(215, 20);
            this.txtNomeH.TabIndex = 7;
            // 
            // txtSalarioHoraH
            // 
            this.txtSalarioHoraH.Location = new System.Drawing.Point(168, 113);
            this.txtSalarioHoraH.Name = "txtSalarioHoraH";
            this.txtSalarioHoraH.Size = new System.Drawing.Size(76, 20);
            this.txtSalarioHoraH.TabIndex = 8;
            // 
            // txtNumeroHorasH
            // 
            this.txtNumeroHorasH.Location = new System.Drawing.Point(168, 143);
            this.txtNumeroHorasH.Name = "txtNumeroHorasH";
            this.txtNumeroHorasH.Size = new System.Drawing.Size(76, 20);
            this.txtNumeroHorasH.TabIndex = 9;
            // 
            // txtDataEntradaEmpresaH
            // 
            this.txtDataEntradaEmpresaH.Location = new System.Drawing.Point(168, 171);
            this.txtDataEntradaEmpresaH.Name = "txtDataEntradaEmpresaH";
            this.txtDataEntradaEmpresaH.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntradaEmpresaH.TabIndex = 10;
            // 
            // txtDiasFaltasH
            // 
            this.txtDiasFaltasH.Location = new System.Drawing.Point(168, 198);
            this.txtDiasFaltasH.Name = "txtDiasFaltasH";
            this.txtDiasFaltasH.Size = new System.Drawing.Size(100, 20);
            this.txtDiasFaltasH.TabIndex = 11;
            // 
            // btnInstanciarHora
            // 
            this.btnInstanciarHora.Location = new System.Drawing.Point(35, 260);
            this.btnInstanciarHora.Name = "btnInstanciarHora";
            this.btnInstanciarHora.Size = new System.Drawing.Size(180, 41);
            this.btnInstanciarHora.TabIndex = 12;
            this.btnInstanciarHora.Text = "Instanciar Hora";
            this.btnInstanciarHora.UseVisualStyleBackColor = true;
            this.btnInstanciarHora.Click += new System.EventHandler(this.btnInstanciarHora_Click);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 368);
            this.Controls.Add(this.btnInstanciarHora);
            this.Controls.Add(this.txtDiasFaltasH);
            this.Controls.Add(this.txtDataEntradaEmpresaH);
            this.Controls.Add(this.txtNumeroHorasH);
            this.Controls.Add(this.txtSalarioHoraH);
            this.Controls.Add(this.txtNomeH);
            this.Controls.Add(this.txtMatriculaH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatriculaH;
        private System.Windows.Forms.TextBox txtNomeH;
        private System.Windows.Forms.TextBox txtSalarioHoraH;
        private System.Windows.Forms.TextBox txtNumeroHorasH;
        private System.Windows.Forms.TextBox txtDataEntradaEmpresaH;
        private System.Windows.Forms.TextBox txtDiasFaltasH;
        private System.Windows.Forms.Button btnInstanciarHora;
    }
}