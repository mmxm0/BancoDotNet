using System;

namespace Banco.Contas
{
    public abstract class Conta
    { 
        public int Numero { get; set; }
        public double Saldo { get;   set; }
        public Cliente Titular { get; set; }
        public static int totalDeContas;



        public Conta()
        {
            Conta.totalDeContas++;
            Numero = Conta.totalDeContas;
        }

        public override string ToString()
        {
            return "Titular: "+ Titular.Nome;
        }
        public static int ProximoNumero()
        {
            return totalDeContas+1;
        }

        public abstract void Deposita(double valorOperacao);

        public abstract void Saca(double valorOperacao);

        public abstract void Transfere( Conta conta, double valorOperacao);

    }
}