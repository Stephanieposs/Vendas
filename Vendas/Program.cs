
using System.Runtime.CompilerServices;

namespace Vendas
{
    internal class Program
    {
        static void Main(string[] args)
        {




            RepositorioClient repo = new RepositorioClient();

            Cliente cliente = new ClienteRegistrado(1, "Stephanie", "12991006943", 0);
            repo.Save(cliente);





            /*

            // cadastro cliente se informado
            CupomFiscal cf = new CupomFiscal("Cartão de crédito");

            ClienteRegistrado c1 = new ClienteRegistrado(1,"Stephanie", "12991006943", 0);
            cf.adicionarCliente(c1);
            


            // Adicionando produtos 
            Venda v1 = new Venda(5, "pão", 5.00);
            Venda v2 = new Venda(10, "bolo", 5.00);
            cf.adicionarVenda(v2);
            cf.adicionarVenda(v1);


            cf.imprimir();


            CupomFiscal cf1 = new CupomFiscal("Dinheiro");
            cf1.adicionarCliente(c1);
            Venda v3 = new Venda(5, "pão", 5.00);
            Venda v4 = new Venda(10, "bolo", 5.00);
            cf1.adicionarVenda(v3);
            cf1.adicionarVenda(v4);

            cf1.imprimir();


            CupomFiscal cf3 = new CupomFiscal("Débito");
            ClienteNulo c2 = new ClienteNulo();
            //cf3.adicionarCliente(c2);
            Venda v5 = new Venda(5, "pão", 5.00);
            Venda v6 = new Venda(10, "bolo", 5.00);
            cf3.adicionarVenda(v5);
            cf3.adicionarVenda(v6);

            cf3.imprimir();

            */

            Console.ReadKey();
        }

        
    }
}
