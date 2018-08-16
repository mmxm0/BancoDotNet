using Banco.Busca;
using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form

    {
        private ICollection<string> devedores;
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            devedores = gerador.GerarList();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNumero_Click(object sender, EventArgs e)
        {

        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            bool ehDevedor = devedores.Contains(titular);

            if (!ehDevedor)
            { ContaCorrente conta = new ContaCorrente();
                conta.Titular = new Cliente(textoTitular.Text);
            

                formPrincipal.AdicionaConta(conta);
                textoTitular.Text = "";
                textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
                MessageBox.Show("Cadastro realizado com sucesso!"); }
            else
            {
                MessageBox.Show("Devedor");
            }
            
        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero());
        }
    }
}
