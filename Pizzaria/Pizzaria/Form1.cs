using Pizzaria.Base;
using Pizzaria.Features.Bebidas;
using Pizzaria.Features.Clientes;
using Pizzaria.Features.Pedidos;
using Pizzaria.Features.Pizzas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Form1 : Form
    {
        GerenciadorFormulario _forms;
        public Form1()
        {
            InitializeComponent();
            _forms = new ClienteFormulario();
            this.AtualizarForms(_forms);
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _forms = new PedidoFormulario();
            this.AtualizarForms(_forms);
        }

        private void AtualizarForms(GerenciadorFormulario forms)
        {
            this._forms = forms;

            UserControl _userControl = this._forms.CarregarListagem();

            _userControl.Dock = DockStyle.Fill;

            panel.Controls.Clear();

            panel.Controls.Add(_userControl);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _forms = new ClienteFormulario();
            this.AtualizarForms(_forms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._forms.Adicionar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._forms.Atualizar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this._forms.Remover();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _forms = new BebidaFormulario();
            this.AtualizarForms(_forms);
        }

        private void pizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _forms = new PizzaFormulario();
            this.AtualizarForms(_forms);
        }
    }
}
