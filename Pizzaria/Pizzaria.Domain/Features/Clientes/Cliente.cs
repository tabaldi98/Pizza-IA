using Pizzaria.Domain.Base;
using Pizzaria.Domain.Features.Enderecos;
using Pizzaria.Domain.Features.Ordem_de_Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Features.Clientes
{
    public class Cliente : Entidade
    {
        public Endereco Endereco { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Email { get; set; }
        public List<Ordem> Pedidos { get; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
