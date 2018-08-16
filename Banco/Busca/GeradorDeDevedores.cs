using System.Collections.Generic;

namespace Banco.Busca
{
    class GeradorDeDevedores
    {
        public HashSet<string> GerarList()
        {
            HashSet<string> nomes = new  HashSet<string>();
            for (int i=0; i<3000; i++) {
                nomes.Add("devedor " + i);
            }
            return nomes;
        }
    }
}
