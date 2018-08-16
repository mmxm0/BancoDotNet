namespace Banco
{
    partial class FormCadastroConta
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.groupBoxCadastroConta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCadastroConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(19, 22);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Numero";
            this.labelNumero.Click += new System.EventHandler(this.labelNumero_Click);
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(66, 71);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastro.TabIndex = 2;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(82, 19);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 3;
            this.textoNumero.TextChanged += new System.EventHandler(this.textoNumero_TextChanged);
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(82, 42);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 4;
            this.textoTitular.TextChanged += new System.EventHandler(this.textoTitular_TextChanged);
            // 
            // groupBoxCadastroConta
            // 
            this.groupBoxCadastroConta.Controls.Add(this.label1);
            this.groupBoxCadastroConta.Controls.Add(this.botaoCadastro);
            this.groupBoxCadastroConta.Controls.Add(this.textoTitular);
            this.groupBoxCadastroConta.Controls.Add(this.textoNumero);
            this.groupBoxCadastroConta.Controls.Add(this.labelNumero);
            this.groupBoxCadastroConta.Location = new System.Drawing.Point(20, 24);
            this.groupBoxCadastroConta.Name = "groupBoxCadastroConta";
            this.groupBoxCadastroConta.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCadastroConta.TabIndex = 5;
            this.groupBoxCadastroConta.TabStop = false;
            this.groupBoxCadastroConta.Text = "Cadastro de Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 181);
            this.Controls.Add(this.groupBoxCadastroConta);
            this.Name = "FormCadastroConta";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.groupBoxCadastroConta.ResumeLayout(false);
            this.groupBoxCadastroConta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.GroupBox groupBoxCadastroConta;
        private System.Windows.Forms.Label label1;
    }
}