namespace Banco
{
    partial class FormRelatorios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.botaoContaAntiga = new System.Windows.Forms.Button();
            this.groupResumo = new System.Windows.Forms.GroupBox();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.labelTotalS = new System.Windows.Forms.Label();
            this.labelMaiorS = new System.Windows.Forms.Label();
            this.groupResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 12);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(237, 160);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(12, 268);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(135, 23);
            this.botaoFiltroSaldo.TabIndex = 1;
            this.botaoFiltroSaldo.Text = "Saldo maior que 5000";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // botaoContaAntiga
            // 
            this.botaoContaAntiga.Location = new System.Drawing.Point(178, 268);
            this.botaoContaAntiga.Name = "botaoContaAntiga";
            this.botaoContaAntiga.Size = new System.Drawing.Size(71, 23);
            this.botaoContaAntiga.TabIndex = 2;
            this.botaoContaAntiga.Text = " Antigas";
            this.botaoContaAntiga.UseVisualStyleBackColor = true;
            this.botaoContaAntiga.Click += new System.EventHandler(this.botaoContaAntiga_Click);
            // 
            // groupResumo
            // 
            this.groupResumo.Controls.Add(this.labelMaiorS);
            this.groupResumo.Controls.Add(this.labelTotalS);
            this.groupResumo.Controls.Add(this.labelMaiorSaldo);
            this.groupResumo.Controls.Add(this.labelSaldoTotal);
            this.groupResumo.Location = new System.Drawing.Point(12, 178);
            this.groupResumo.Name = "groupResumo";
            this.groupResumo.Size = new System.Drawing.Size(237, 84);
            this.groupResumo.TabIndex = 3;
            this.groupResumo.TabStop = false;
            this.groupResumo.Text = "Resumo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(15, 28);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(61, 13);
            this.labelSaldoTotal.TabIndex = 0;
            this.labelSaldoTotal.Text = "Saldo Total";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(15, 57);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(63, 13);
            this.labelMaiorSaldo.TabIndex = 1;
            this.labelMaiorSaldo.Text = "Maior Saldo";
            // 
            // labelTotalS
            // 
            this.labelTotalS.AutoSize = true;
            this.labelTotalS.Location = new System.Drawing.Point(163, 27);
            this.labelTotalS.Name = "labelTotalS";
            this.labelTotalS.Size = new System.Drawing.Size(35, 13);
            this.labelTotalS.TabIndex = 2;
            this.labelTotalS.Text = "label3";
            // 
            // labelMaiorS
            // 
            this.labelMaiorS.AutoSize = true;
            this.labelMaiorS.Location = new System.Drawing.Point(166, 57);
            this.labelMaiorS.Name = "labelMaiorS";
            this.labelMaiorS.Size = new System.Drawing.Size(35, 13);
            this.labelMaiorS.TabIndex = 3;
            this.labelMaiorS.Text = "label4";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 317);
            this.Controls.Add(this.groupResumo);
            this.Controls.Add(this.botaoContaAntiga);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.groupResumo.ResumeLayout(false);
            this.groupResumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.Button botaoContaAntiga;
        private System.Windows.Forms.GroupBox groupResumo;
        private System.Windows.Forms.Label labelMaiorS;
        private System.Windows.Forms.Label labelTotalS;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelSaldoTotal;
    }
}