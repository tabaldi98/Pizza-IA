using Pizzaria.Domain.Base;
using Pizzaria.Domain.Features.Sabores;
using System;
using System.Collections.Generic;

namespace Pizzaria.Domain.Features.Pizzas
{
    public class Pizza : Entidade
    {
        public TamanhoPizza TamanhoPizza { get; set; }

        public List<Sabor> Sabores { get; set; }

        public double Valor { get; set; }

        public Pizza()
        {
            Sabores = new List<Sabor>();
        }

        public void AdicionarSabor(Sabor sabor)
        {
            this.Sabores.Add(sabor);
        }

        public void RemoverTodosSabores()
        {
            this.Sabores = new List<Sabor>();
        }

        public void Validar()
        {
            if (Sabores.Count > 4)
                throw new Exception("A pizza pode ter no máximo 4 sabores");
            if (Sabores.Count == 3)
                throw new Exception("A pizza não pode ter 3 sabores");
        }

        public override string ToString()
        {

            string retorno = "Pizza: " + TamanhoPizza.ToString();

            if (Sabores.Count < 1)
                return retorno;

            if (Sabores.Count == 1)
                retorno += " | Sabor";

            if (Sabores.Count > 1)
                retorno += " | Sabores";

            foreach (var item in Sabores)
            {
                retorno += " - " + item.Descricao;
            }

            return retorno;
        }

        public void Promocao(double porcentagem)
        {
            this.Valor = (this.Valor * 100) / porcentagem;
        }

    }
}
