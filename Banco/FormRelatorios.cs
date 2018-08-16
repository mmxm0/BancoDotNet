using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var resultadoQuery = contas.Where(conta => conta.Saldo > 5000);
            foreach(var conta in resultadoQuery)
            {
                listaResultado.Items.Add(conta);
            }
        }

        private void botaoContaAntiga_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            try
            {
                var filtradas = from c in contas where c.Numero <= 10 select c;
                var filtradas2 = from c in filtradas where c.Saldo < 1000 orderby c.Titular.Nome, c.Saldo  select c;
                foreach (var conta in filtradas2)
                {
                    listaResultado.Items.Add(conta);
                }
                double saldoTotal = filtradas2.Sum(conta => conta.Saldo);
                double maiorSaldo = filtradas2.Max(conta => conta.Saldo);

                labelTotalS.Text = Convert.ToString(saldoTotal);
                labelMaiorS.Text = Convert.ToString(maiorSaldo);
            }
            catch(Exception)
            {
                MessageBox.Show("A busca não retornou nenhum resultado");
            }

        }
    }
}
