namespace Banco
{
    partial class Form1
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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.groupConta = new System.Windows.Forms.GroupBox();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBuscaConta = new System.Windows.Forms.GroupBox();
            this.botaoBuscaTitular = new System.Windows.Forms.Button();
            this.textoBuscaTitular = new System.Windows.Forms.TextBox();
            this.labelBuscaTitular = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.escolhaConta = new System.Windows.Forms.Label();
            this.comboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.groupTransferencia = new System.Windows.Forms.GroupBox();
            this.textoValorTranferir = new System.Windows.Forms.Label();
            this.textoValorTransferir = new System.Windows.Forms.TextBox();
            this.labelTransfConta = new System.Windows.Forms.Label();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.botaoRelatorio = new System.Windows.Forms.Button();
            this.groupConta.SuspendLayout();
            this.groupBuscaConta.SuspendLayout();
            this.groupTransferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(73, 26);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(195, 20);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(73, 52);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(195, 20);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.TextChanged += new System.EventHandler(this.textoNumero_TextChanged);
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(73, 78);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(195, 20);
            this.textoSaldo.TabIndex = 2;
            this.textoSaldo.TextChanged += new System.EventHandler(this.textoSaldo_TextChanged);
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(91, 140);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(61, 23);
            this.botaoDeposito.TabIndex = 4;
            this.botaoDeposito.Text = "Deposita";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(176, 140);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(59, 23);
            this.botaoSaque.TabIndex = 5;
            this.botaoSaque.Text = "Saca";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(73, 104);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(195, 20);
            this.textoValor.TabIndex = 6;
            this.textoValor.TextChanged += new System.EventHandler(this.textoValor_TextChanged);
            // 
            // groupConta
            // 
            this.groupConta.Controls.Add(this.botaoRelatorio);
            this.groupConta.Controls.Add(this.botaoImpostos);
            this.groupConta.Controls.Add(this.botaoNovaConta);
            this.groupConta.Controls.Add(this.label5);
            this.groupConta.Controls.Add(this.label4);
            this.groupConta.Controls.Add(this.label2);
            this.groupConta.Controls.Add(this.label1);
            this.groupConta.Controls.Add(this.textoValor);
            this.groupConta.Controls.Add(this.botaoDeposito);
            this.groupConta.Controls.Add(this.botaoSaque);
            this.groupConta.Controls.Add(this.textoNumero);
            this.groupConta.Controls.Add(this.textoSaldo);
            this.groupConta.Controls.Add(this.textoTitular);
            this.groupConta.Location = new System.Drawing.Point(41, 110);
            this.groupConta.Name = "groupConta";
            this.groupConta.Size = new System.Drawing.Size(290, 236);
            this.groupConta.TabIndex = 7;
            this.groupConta.TabStop = false;
            this.groupConta.Text = "Conta";
            this.groupConta.Enter += new System.EventHandler(this.groupConta_Enter);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(87, 197);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(92, 23);
            this.botaoImpostos.TabIndex = 12;
            this.botaoImpostos.Text = "Calcula Tributos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(9, 197);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(72, 23);
            this.botaoNovaConta.TabIndex = 11;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saldo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Titular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBuscaConta
            // 
            this.groupBuscaConta.Controls.Add(this.botaoBuscaTitular);
            this.groupBuscaConta.Controls.Add(this.textoBuscaTitular);
            this.groupBuscaConta.Controls.Add(this.labelBuscaTitular);
            this.groupBuscaConta.Controls.Add(this.comboContas);
            this.groupBuscaConta.Controls.Add(this.escolhaConta);
            this.groupBuscaConta.Location = new System.Drawing.Point(41, 12);
            this.groupBuscaConta.Name = "groupBuscaConta";
            this.groupBuscaConta.Size = new System.Drawing.Size(290, 92);
            this.groupBuscaConta.TabIndex = 8;
            this.groupBuscaConta.TabStop = false;
            this.groupBuscaConta.Text = "Busca de Conta";
            // 
            // botaoBuscaTitular
            // 
            this.botaoBuscaTitular.Location = new System.Drawing.Point(210, 53);
            this.botaoBuscaTitular.Name = "botaoBuscaTitular";
            this.botaoBuscaTitular.Size = new System.Drawing.Size(58, 23);
            this.botaoBuscaTitular.TabIndex = 12;
            this.botaoBuscaTitular.Text = "Buscar";
            this.botaoBuscaTitular.UseVisualStyleBackColor = true;
            this.botaoBuscaTitular.Click += new System.EventHandler(this.botaoBuscaTitular_Click);
            // 
            // textoBuscaTitular
            // 
            this.textoBuscaTitular.Location = new System.Drawing.Point(97, 55);
            this.textoBuscaTitular.Name = "textoBuscaTitular";
            this.textoBuscaTitular.Size = new System.Drawing.Size(78, 20);
            this.textoBuscaTitular.TabIndex = 11;
            // 
            // labelBuscaTitular
            // 
            this.labelBuscaTitular.AutoSize = true;
            this.labelBuscaTitular.Location = new System.Drawing.Point(6, 58);
            this.labelBuscaTitular.Name = "labelBuscaTitular";
            this.labelBuscaTitular.Size = new System.Drawing.Size(87, 13);
            this.labelBuscaTitular.TabIndex = 10;
            this.labelBuscaTitular.Text = "Busca por Titular";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(97, 28);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(171, 21);
            this.comboContas.TabIndex = 9;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // escolhaConta
            // 
            this.escolhaConta.AutoSize = true;
            this.escolhaConta.Location = new System.Drawing.Point(6, 31);
            this.escolhaConta.Name = "escolhaConta";
            this.escolhaConta.Size = new System.Drawing.Size(85, 13);
            this.escolhaConta.TabIndex = 9;
            this.escolhaConta.Text = "Escolha a Conta";
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(97, 29);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(171, 21);
            this.comboDestinoTransferencia.TabIndex = 9;
            this.comboDestinoTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboDestinoTransferencia_SelectedIndexChanged);
            // 
            // groupTransferencia
            // 
            this.groupTransferencia.Controls.Add(this.textoValorTranferir);
            this.groupTransferencia.Controls.Add(this.textoValorTransferir);
            this.groupTransferencia.Controls.Add(this.labelTransfConta);
            this.groupTransferencia.Controls.Add(this.buttonTransferir);
            this.groupTransferencia.Controls.Add(this.comboDestinoTransferencia);
            this.groupTransferencia.Location = new System.Drawing.Point(41, 352);
            this.groupTransferencia.Name = "groupTransferencia";
            this.groupTransferencia.Size = new System.Drawing.Size(290, 131);
            this.groupTransferencia.TabIndex = 10;
            this.groupTransferencia.TabStop = false;
            this.groupTransferencia.Text = "Transferências";
            // 
            // textoValorTranferir
            // 
            this.textoValorTranferir.AutoSize = true;
            this.textoValorTranferir.Location = new System.Drawing.Point(60, 70);
            this.textoValorTranferir.Name = "textoValorTranferir";
            this.textoValorTranferir.Size = new System.Drawing.Size(31, 13);
            this.textoValorTranferir.TabIndex = 13;
            this.textoValorTranferir.Text = "Valor";
            // 
            // textoValorTransferir
            // 
            this.textoValorTransferir.Location = new System.Drawing.Point(97, 67);
            this.textoValorTransferir.Name = "textoValorTransferir";
            this.textoValorTransferir.Size = new System.Drawing.Size(78, 20);
            this.textoValorTransferir.TabIndex = 12;
            this.textoValorTransferir.TextChanged += new System.EventHandler(this.textoValorTransferir_TextChanged);
            // 
            // labelTransfConta
            // 
            this.labelTransfConta.AutoSize = true;
            this.labelTransfConta.Location = new System.Drawing.Point(6, 32);
            this.labelTransfConta.Name = "labelTransfConta";
            this.labelTransfConta.Size = new System.Drawing.Size(85, 13);
            this.labelTransfConta.TabIndex = 11;
            this.labelTransfConta.Text = "Escolha a Conta";
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Location = new System.Drawing.Point(73, 102);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(75, 23);
            this.buttonTransferir.TabIndex = 10;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = true;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // botaoRelatorio
            // 
            this.botaoRelatorio.Location = new System.Drawing.Point(189, 197);
            this.botaoRelatorio.Name = "botaoRelatorio";
            this.botaoRelatorio.Size = new System.Drawing.Size(75, 23);
            this.botaoRelatorio.TabIndex = 13;
            this.botaoRelatorio.Text = "Relatórios";
            this.botaoRelatorio.UseVisualStyleBackColor = true;
            this.botaoRelatorio.Click += new System.EventHandler(this.botaoRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 492);
            this.Controls.Add(this.groupTransferencia);
            this.Controls.Add(this.groupBuscaConta);
            this.Controls.Add(this.groupConta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupConta.ResumeLayout(false);
            this.groupConta.PerformLayout();
            this.groupBuscaConta.ResumeLayout(false);
            this.groupBuscaConta.PerformLayout();
            this.groupTransferencia.ResumeLayout(false);
            this.groupTransferencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.GroupBox groupConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBuscaConta;
        private System.Windows.Forms.Label escolhaConta;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboDestinoTransferencia;
        private System.Windows.Forms.GroupBox groupTransferencia;
        private System.Windows.Forms.Label labelTransfConta;
        private System.Windows.Forms.Button buttonTransferir;
        private System.Windows.Forms.Label textoValorTranferir;
        private System.Windows.Forms.TextBox textoValorTransferir;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button botaoImpostos;
        private System.Windows.Forms.Button botaoBuscaTitular;
        private System.Windows.Forms.TextBox textoBuscaTitular;
        private System.Windows.Forms.Label labelBuscaTitular;
        private System.Windows.Forms.Button botaoRelatorio;
    }
}

