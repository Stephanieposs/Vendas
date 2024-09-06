using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    internal abstract class Cliente
    {

        public long Id { get; set; }
        

        private string Nome;
        public string nome
        {
            get { return Nome; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException("O nome precisa ser informado"); }
                else
                {
                    Nome = value;
                }
            }
        }

        
        private string Cpf;
        public string cpf
        {
            get { return Cpf; }
            set
            {
                if (value.Length != 11)
                { throw new ArgumentNullException("O produto precisa ser informado"); }
                else
                {
                    Cpf = value;
                }
            }
        }

        public int Pontos { get; set; }

        public Cliente() { }

        public Cliente(long id, string nome, string cpf, int pontos)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Pontos = pontos;
        }

    }
}
