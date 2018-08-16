using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class TotalizadorDeTributos
    {
        public double TotalTributos { get; private set; }

        public void Adiciona(ITributavel t)
        {
            TotalTributos += t.CalculaTributos();
        }
    }
}
