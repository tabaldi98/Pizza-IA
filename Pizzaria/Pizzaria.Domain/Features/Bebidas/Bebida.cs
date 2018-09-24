using Pizzaria.Domain.Base;
using Pizzaria.Domain.Features.Sabores;
using System;

namespace Pizzaria.Domain.Features.Bebidas
{
    public class Bebida : Entidade
    {
        public TamanhoBebida TamanhoBebida { get; set; }
        public double Valor { get; set; }
        public Sabor Sabor { get; set; }

        public void Validar()
        {
            if (Valor < 1)
                throw new Exception("Valor Não definido");
            if(Sabor == null)
                throw new Exception("Sabor Não definido");

        }

        public override string ToString()
        {
            return TamanhoBebida.ToString() + " - " + Sabor.Descricao;
        }

    }
}
