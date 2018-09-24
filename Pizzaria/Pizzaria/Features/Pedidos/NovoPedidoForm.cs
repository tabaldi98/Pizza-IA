using Pizzaria.Aplicacao.Features.Sabores;
using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Domain.Features.Ordem_de_Compra;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Sabores;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Sabores;
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
    public partial class NovoPedidoForm : Form
    {
        #region Private Objects
        Pizza _pizza = new Pizza();
        Bebida _bebida = new Bebida();
        Cliente _cliente;
        private Ordem _ordem = new Ordem();

        ISaborServico _saborServico;
        #endregion
        public NovoPedidoForm(Ordem ordem = null)
        {
            InitializeComponent();

            groupBebida.Enabled = false;
            groupBoxTroco.Visible = false;
            checkBoxTroco.Visible = false;
            PopulaComboPagamento();

            var saborRepositorio = new SaborRepositorio(new PizzariaContext());
            _saborServico = new SaborServico(saborRepositorio);

            AtualizarSaborPizza();
            this.AtualizarSaborBebida();

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

        public TipoPagamento VerificaTipoPagamento()
        {
            string selecionado = comboBoxPagamento.SelectedItem.ToString();

            switch (selecionado)
            {
                case "Dinheiro":
                    return TipoPagamento.Dinheiro;
                case "Cheque":
                    return TipoPagamento.Cheque;
                case "Débito":
                    return TipoPagamento.Debito;
                case "Crédito":
                    return TipoPagamento.Credito;
                default:
                    return TipoPagamento.Dinheiro;
            }

        }

        private void comboBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipo = VerificaTipoPagamento();

            if (tipo == TipoPagamento.Dinheiro)
                checkBoxTroco.Visible = true;
            else
            {
                checkBoxTroco.Visible = false;
                groupBoxTroco.Visible = false;
            }
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
            AtualizarSaborPizza();
        }

        private void tamanhoMedia_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarSaborPizza();

        }

        private void tamanhoGrande_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarSaborPizza();

        }

        private void tamanhoGigante_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarSaborPizza();

        }

        private void tamanhoExtraGigante_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarSaborPizza();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_pizza.Sabores.Count < 1)
            {
                MessageBox.Show("Selecione pelo menos um sabor para a pizza");
                return;
            }

            _pizza.TamanhoPizza = this.VerificarQualTamanhoPizza();
            this.AdicionarPizzaNaOrdem(_pizza);

            lblValorTotal.Text = _ordem.ValorTotal.ToString();

        }

        private void AdicionarPizzaNaOrdem(Pizza pizza)
        {
            listBoxResumo.Items.Clear();

            this._ordem.AdicionarPizza(pizza);

            foreach (var item in _ordem.Pizzas)
            {
                listBoxResumo.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var bebida = comboBoxSaborBebida.SelectedItem as Bebida;
            if (bebida == null)
            {
                MessageBox.Show("Selecione pelo menos sabor");
                return;
            }
            _bebida = bebida;
            this.AdicionarBebidaNaOrdem(_bebida);

            lblValorTotal.Text = _ordem.ValorTotal.ToString();

        }

        private void AdicionarBebidaNaOrdem(Bebida bebida)
        {

            this._ordem.AdicionarBebida(bebida);

            listBoxResumo.Items.Add(bebida);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarClienteForm selecionarClienteForm = new SelecionarClienteForm();
            selecionarClienteForm.ShowDialog();
            if (selecionarClienteForm.DialogResult == DialogResult.OK)
            {
                txtNomeCliente.Text = selecionarClienteForm.Selecionado.Nome;
                this._cliente = selecionarClienteForm.Selecionado;
            }
        }

        private TamanhoPizza VerificarQualTamanhoPizza()
        {

            if (tamanhoPequena.Checked)
                return TamanhoPizza.Pequena;
            else if (tamanhoMedia.Checked)
                return TamanhoPizza.Media;
            else if (tamanhoGrande.Checked)
                return TamanhoPizza.Grande;
            else if (tamanhoGigante.Checked)
                return TamanhoPizza.Gigante;
            else
                return TamanhoPizza.ExtraGigante;
        }

        private TamanhoBebida VerificarQualTamanhoBebida()
        {
            if (tamanhoLata.Checked)
                return TamanhoBebida.Lata;
            else if (tamanhoLitro.Checked)
                return TamanhoBebida.Litro;
            else if (tamanhoLitrão.Checked)
                return TamanhoBebida.Litrao;
            else
                return TamanhoBebida.Garrafa;
        }

        private void AtualizarSaborPizza()
        {
            _pizza.TamanhoPizza = this.VerificarQualTamanhoPizza();

            var sabores = _saborServico.GetAllPorTipo(TipoSabor.Pizza);

            comboBoxSabor1.Items.Clear();
            comboBoxSabor2.Items.Clear();
            comboBoxSabor3.Items.Clear();
            comboBoxSabor4.Items.Clear();

            if (sabores == null)
                return;

            foreach (var item in sabores)
            {
                comboBoxSabor1.Items.Add(item);
                comboBoxSabor2.Items.Add(item);
                comboBoxSabor3.Items.Add(item);
                comboBoxSabor4.Items.Add(item);
            }
        }

        private void comboBoxSabor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = comboBoxSabor1.SelectedItem as Sabor;

            if (selecionado == null)
                return;

            _pizza.AdicionarSabor(selecionado);
        }

        private void comboBoxSabor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = comboBoxSabor2.SelectedItem as Sabor;

            if (selecionado == null)
                return;

            _pizza.AdicionarSabor(selecionado);
        }

        private void comboBoxSabor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = comboBoxSabor3.SelectedItem as Sabor;

            if (selecionado == null)
                return;

            _pizza.AdicionarSabor(selecionado);
        }

        private void comboBoxSabor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = comboBoxSabor4.SelectedItem as Sabor;

            if (selecionado == null)
                return;

            _pizza.AdicionarSabor(selecionado);
        }


        private void tamanhoLata_CheckedChanged(object sender, EventArgs e)
        {
            this.AtualizarSaborBebida();
        }

        private void AtualizarSaborBebida()
        {
            var sabores = _saborServico.GetAllPorTipo(TipoSabor.Bebida);

            comboBoxSaborBebida.Items.Clear();

            foreach (var item in sabores)
            {
                comboBoxSaborBebida.Items.Add(item);
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selecionado = comboBoxSaborBebida.SelectedItem as Sabor;

            if (selecionado == null)
                return;

            _bebida.Sabor = selecionado;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this._ordem.RemoverTodosProdutos();
            listBoxResumo.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._ordem.Cliente = this._cliente;
            //this._ordem.ValorEntrega
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (_ordem.ValorTotal < 1 || numericUpDownDinheiro.Value < 1)
                return;
            var diferenca = Convert.ToDouble(numericUpDownDinheiro.Value) - _ordem.ValorTotal;
            labelTroco.Text = diferenca.ToString();
        }
    }
}
