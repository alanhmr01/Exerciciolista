using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciolista
{
    public class Vendas
    {
        public int IdVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public List<string> Produtos { get; set; }

        public void ImprimirLista()
        {
            Console.WriteLine("ID da Venda: " + IdVenda);
            Console.WriteLine("Data da Venda: " + DataVenda);
            Console.WriteLine("Produtos Comprados:");
            foreach (string produto in Produtos)
            {
                Console.WriteLine("- " + produto);
            }
            Console.WriteLine();
        }
    }
}
