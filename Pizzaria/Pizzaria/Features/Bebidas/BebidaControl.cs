using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.Aplicacao.Features.Bebidas;
using Pizzaria.Infra.ORM.Features.Bebidas;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Infra.ORM.Features.Sabores;

namespace Pizzaria.Features.Bebidas
{
    public partial class BebidaControl : UserControl
    {
        private IBebidaServico _servico;
        public BebidaControl()
        {
            InitializeComponent();
            var context = new PizzariaContext();
            var bebidaRepositorio = new BebidaRepositorio(context);
            var saborRepositorio = new SaborRepositorio(context);
            _servico = new BebidaServico(bebidaRepositorio, saborRepositorio);
            AtualizarLista();
            this.dataGridViewClientes.AutoGenerateColumns = true;

        }

        public void AtualizarLista()
        {
            dataGridViewClientes.DataSource = null;

            var list = _servico.GetAll();

            dataGridViewClientes.DataSource = list;

        }

        public Bebida ObterSelecionado()
        {
            var selecionado = dataGridViewClientes.CurrentRow.DataBoundItem;

            return selecionado as Bebida;
        }
    }
}
