﻿using Pizzaria.Domain.Features.Produtos;
using Pizzaria.Domain.Features.Sabores;

namespace Pizzaria.Domain.Features.Bebidas
{
    public class Bebida : Produto
    {
        public TamanhoBebida TamanhoBebida { get; set; }
        public Sabor Sabor { get; set; }
    }
}
