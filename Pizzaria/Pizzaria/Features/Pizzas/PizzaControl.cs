using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.Aplicacao.Features.Pizzas;
using Pizzaria.Infra.ORM.Features.Pizzas;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Infra.ORM.Features.Sabores;

namespace Pizzaria.Features.Pizzas
{
    public partial class PizzaControl : UserControl
    {
        private IPizzaServico _servico;
        public PizzaControl()
        {
            InitializeComponent();
            var contexto = new PizzariaContext();
            var pizzaRepositorio = new PizzaRepositorio(contexto);
            var saborRepositorio = new SaborRepositorio(contexto);
            _servico = new PizzaServico(pizzaRepositorio, saborRepositorio);
            dataGridViewPizzas.AutoGenerateColumns = true;
            AtualizarLista();
        }

        public void AtualizarLista()
        {
            var list = _servico.GetAll();

            dataGridViewPizzas.DataSource = null;

            dataGridViewPizzas.DataSource = list;
        }

        public Pizza ObterSelecionado()
        {
            return dataGridViewPizzas.CurrentRow.DataBoundItem as Pizza;
        }
    }
}
