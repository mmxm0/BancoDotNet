using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {

        private List<Conta> contas;
        private int qtddContaCadastrada;
        private Dictionary<string, Conta> dicionario;

        public Form1()
        { 
            InitializeComponent();
        }
        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            qtddContaCadastrada += contas.Count;
            comboContas.Items.Add(conta);
            comboDestinoTransferencia.Items.Add(conta);
            dicionario.Add(conta.Titular.Nome, conta);
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }



        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);

            try
            {
                selecionada.Deposita(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                textoValor.Text = "";
                MessageBox.Show("Operação Realizada com Sucesso!");
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Valor inválido.");
            }
           

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dicionario = new Dictionary<string, Conta>();
            contas = new List<Conta>();

            Conta conta1 = new ContaCorrente();
            conta1.Titular = new Cliente("Marta");

            AdicionaConta(conta1);

            Conta conta2 = new ContaCorrente();
            conta2.Titular = new Cliente("Anderson");


            AdicionaConta(conta2);

            Conta conta3 = new ContaPoupanca();
            conta3.Titular = new Cliente("William");

            AdicionaConta(conta3);

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;

            Conta selecionada = contas[indice];
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            try { selecionada.Saca(valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Operação Realizada com sucesso!");
            }
            catch (SaldoInsuficienteException){ MessageBox.Show("Saldo insuficiente"); }
            catch (ArgumentException) { MessageBox.Show("Valor inválido"); }
                


        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupConta_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoTitular.Text = selecionada.Titular.Nome;
        }

        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            int indice2 = comboDestinoTransferencia.SelectedIndex;
            Conta destino = contas[indice2];
            Conta selecionada = contas[indice];
            string valorDigitado = textoValorTransferir.Text;
            double valor = Convert.ToDouble(valorDigitado);
            try
            {
                selecionada.Transfere(destino, valor);
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Operação Realizada com Sucesso!");
            }
            catch (SaldoInsuficienteException)
            {
                MessageBox.Show("Não há saldo suficiente para essa operação.");
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Valor inválido.");
            }
        }

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textoValorTransferir_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {

            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200);
            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos tributos = new TotalizadorDeTributos();
            tributos.Adiciona(conta);
            MessageBox.Show("Total: " + tributos.TotalTributos);

            tributos.Adiciona(sv);
            MessageBox.Show("Total: " + tributos.TotalTributos);

        }

        private void botaoBuscaTitular_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeTitular = textoBuscaTitular.Text;
                Conta conta = dicionario[nomeTitular];
                comboContas.SelectedItem = conta;
            }
            catch(KeyNotFoundException) {
                MessageBox.Show("Usuário não encontrado.");
            }

            

        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(contas);
            form.ShowDialog();
        }
    }
}
