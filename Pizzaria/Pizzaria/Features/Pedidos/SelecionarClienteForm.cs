using Pizzaria.Aplicacao.Features.Clientes;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Features.Pedidos
{
    public partial class SelecionarClienteForm : Form
    {
        private IClienteServico _servico;
        public Cliente Selecionado { get; internal set; }
        public SelecionarClienteForm()
        {
            InitializeComponent();

            var repositorio = new ClienteRepositorio(new PizzariaContext());
            _servico = new ClienteServico(repositorio);
            this.dataGridViewClientes.AutoGenerateColumns = true;

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dataGridViewClientes.DataSource = null;

            var list = _servico.GetAll();

            dataGridViewClientes.DataSource = list;

            dataGridViewClientes.Columns["Endereco"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxTelefone.Text = string.Empty;
            this.AtualizarLista();
        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            var cliente = _servico.GetPorTelefone(textBoxTelefone.Text);

            if (cliente == null)
                return;

            dataGridViewClientes.DataSource = null;

            dataGridViewClientes.DataSource = cliente;

            dataGridViewClientes.Columns["Endereco"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selecionado = dataGridViewClientes.CurrentRow.DataBoundItem as Cliente;

            if (selecionado == null)
            {
                button1.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Atenção", "Selecione um cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                this.Selecionado = selecionado;
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
