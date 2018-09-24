using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Infra.ORM.Features.Clientes;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Aplicacao.Features.Clientes;

namespace Pizzaria.Features.Clientes
{
    public partial class ClienteControl : UserControl
    {
        private IClienteServico _servico;
        public ClienteControl()
        {
            InitializeComponent();
            var repositorio = new ClienteRepositorio(new PizzariaContext());
            _servico = new ClienteServico(repositorio);
            AtualizarLista();
            this.dataGridViewClientes.AutoGenerateColumns = true;
        }

        public void AtualizarLista()
        {
            dataGridViewClientes.DataSource = null;

            var list = _servico.GetAll();

            dataGridViewClientes.DataSource = list;

            dataGridViewClientes.Columns["Endereco"].Visible = false;
        }

        public Cliente ObterSelecionado()
        {
            var selecionado = dataGridViewClientes.CurrentRow.DataBoundItem;

            return selecionado as Cliente;
        }
    }
}
