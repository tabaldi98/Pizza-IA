using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Pedidos
{
    public partial class NovoPedidoForm : Form
    {
        Pizza pizza = new Pizza();
        Bebida bebida = new Bebida();

        public NovoPedidoForm()
        {
            InitializeComponent();
            groupBebida.Enabled = false;
            groupBoxTroco.Visible = false;
            checkBoxTroco.Visible = false;
            PopulaComboPagamento();
            pizza.TamanhoPizza = TamanhoPizza.Gigante;
            bebida.TamanhoBebida = TamanhoBebida.Litrao;

        }

        private void checkBoxBebida_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBebida.Checked)
                groupBebida.Enabled = true;
            else
                groupBebida.Enabled = false;
        }

        private void checkBoxTroco_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTroco.Checked)
                groupBoxTroco.Visible = true;
            else
                groupBoxTroco.Visible = false;

        }

        public void ValidaSePrecisaDeTroco()
        {
            string selecionado = comboBoxPagamento.SelectedItem.ToString();

            if (selecionado.Equals("Dinheiro"))
                checkBoxTroco.Visible = true;
            else
            {
                checkBoxTroco.Visible = false;
                groupBoxTroco.Visible = false;
            }
        }

        private void comboBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidaSePrecisaDeTroco();
        }

        private void PopulaComboPagamento()
        {
            List<string> pagamento = new List<string>();

            pagamento.Add("Dinheiro");
            pagamento.Add("Débito");
            pagamento.Add("Crédito");
            pagamento.Add("Cheque");

            foreach (var item in pagamento)
            {
                comboBoxPagamento.Items.Add(item);
            }
        }

        private void tamanhoPequena_CheckedChanged(object sender, EventArgs e)
        {
            pizza.TamanhoPizza = TamanhoPizza.Pequena;
        }

        private void tamanhoMedia_CheckedChanged(object sender, EventArgs e)
        {
            pizza.TamanhoPizza = TamanhoPizza.Media;

        }

        private void tamanhoGrande_CheckedChanged(object sender, EventArgs e)
        {
            pizza.TamanhoPizza = TamanhoPizza.Grande;

        }

        private void tamanhoGigante_CheckedChanged(object sender, EventArgs e)
        {
            pizza.TamanhoPizza = TamanhoPizza.Gigante;

        }

        private void tamanhoExtraGigante_CheckedChanged(object sender, EventArgs e)
        {
            pizza.TamanhoPizza = TamanhoPizza.ExtraGigante;

        }

        private void tamanhoLata_CheckedChanged(object sender, EventArgs e)
        {
            bebida.TamanhoBebida = TamanhoBebida.Lata;
        }

        private void tamanhoGarrafa_CheckedChanged(object sender, EventArgs e)
        {
            bebida.TamanhoBebida = TamanhoBebida.Garrafa;

        }

        private void tamanhoLitro_CheckedChanged(object sender, EventArgs e)
        {
            bebida.TamanhoBebida = TamanhoBebida.Litro;

        }

        private void tamanhoLitrão_CheckedChanged(object sender, EventArgs e)
        {
            bebida.TamanhoBebida = TamanhoBebida.Litrao;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = new List<Produto>();
            list.Add(bebida);
            list.Add(pizza);

            dgResumo.DataSource = list;
        }
    }
}
