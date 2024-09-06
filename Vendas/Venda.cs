using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    internal class Venda 
    {
        private int Quantidade;
        public int quantidade
        {
            get { return Quantidade; }
            set
            {
                if ( value <= 0 )
                { throw new ArgumentNullException("A quantidade do produto precisa ser positiva"); }
                else 
                {
                    Quantidade = value;
                }
            }
        }

        private string Produto;
        public string produto
        {
            get { return Produto; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException("O produto precisa ser informado"); }
                else
                {
                    Produto = value;
                }
            }
        }

        

        public double Preco { get; set; }
        public double Total { get; set; }


        public Venda(int quantidade, string produto, double preco) {
            Quantidade = quantidade;
            Produto = produto;
            Preco = preco;
            Total = Quantidade * Preco;
        }

    }
}
