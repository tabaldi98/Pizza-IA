using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.Aplicacao.Features.Pedidos;
using Pizzaria.Infra.ORM.Features.Ordens;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Domain.Features.Ordem_de_Compra;

namespace Pizzaria.Features.Pedidos
{
    public partial class PedidoControl : UserControl
    {
        private IPedidoServico _servico;
        public PedidoControl()
        {
            InitializeComponent();
            var repositorio = new OrdemRepositorio(new PizzariaContext());
            _servico = new PedidoServico(repositorio);
            dataGridViewPedidos.AutoGenerateColumns = true;
            AtualizarLista();
        }

        public void AtualizarLista()
        {
            var list = _servico.GetAll();

            dataGridViewPedidos.DataSource = null;

            dataGridViewPedidos.DataSource = list;
        }

        public Ordem ObterSelecionado()
        {
            return dataGridViewPedidos.CurrentRow.DataBoundItem as Ordem;
        }
    }
}
