using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    internal class ClienteRegistrado : Cliente
    {
        public ClienteRegistrado(long id, string nome, string cpf, int pontos) : base(id, nome, cpf, pontos)
        {

        }

        public ClienteRegistrado() { }
    }
}
