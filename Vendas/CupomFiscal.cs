using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    internal class CupomFiscal
    {
        

        public List<Venda> vendas = new List<Venda>();
        public double TotalVendas = 0;
        public string Pagamento = "";

        public ClienteRegistrado clienteRegistrado { get; private set; }

        public CupomFiscal(string pagamento) 
        {
            Pagamento = pagamento;
        }

        public void adicionarVenda(Venda venda)
        {
            vendas.Add(venda);
            TotalVendas += venda.Total;
        }

        public void adicionarCliente(ClienteRegistrado cliente)
        {
            clienteRegistrado = cliente;
            cliente.Pontos++;
        }


        public void imprimir()
        {
            if (clienteRegistrado != null)
            {
                Console.WriteLine($"Cliente \nId:{clienteRegistrado.Id} Nome:{clienteRegistrado.nome} Cpf:{clienteRegistrado.cpf} Pontos:{clienteRegistrado.Pontos} \n");
            }
            else
            {
                Console.WriteLine("Cliente não informado");
            }

            Console.WriteLine($"Forma de pagamento: {Pagamento} \n");

            foreach (var item in vendas)
            {
                Console.WriteLine($"Produto: {item.produto} Quantidade:{item.quantidade} Preço:{item.Preco.ToString("F2")} Total:{item.Total.ToString("F2")}");
            }

            Console.WriteLine($"Total da compra: {TotalVendas.ToString("F2")}");
            


        }






    }
}
