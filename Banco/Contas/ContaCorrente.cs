using System;

namespace Banco.Contas
{
    public class ContaCorrente : Conta, ITributavel
    {

        public override void Saca(double valorOperacao)
        {
            if (valorOperacao < 0.0)
            {

                throw new ArgumentException();
            }
            if (valorOperacao + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else { Saldo -= (valorOperacao += 0.5); }


        }

        public override void Deposita(double valorOperacao)
        {
            if (valorOperacao < 0.0)
            {
                throw new ArgumentException();
            }
            else { Saldo += (valorOperacao-=0.10); }
            
            

        }

        public override void Transfere(Conta conta, double valorOperacao)
        {
            if (valorOperacao < 0.0)
            {
                throw new ArgumentException();
            }
            if (Saldo < valorOperacao)
            {
                throw new SaldoInsuficienteException();
            }
            else
            {
                Saldo -= valorOperacao;
                conta.Saldo += valorOperacao;
            }
        }

        public double CalculaTributos()
        {
            return (Saldo * 0.5)/100;
        }
    }
}