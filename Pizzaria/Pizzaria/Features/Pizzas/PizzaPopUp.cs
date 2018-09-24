using Pizzaria.Aplicacao.Features.Pizzas;
using Pizzaria.Domain.Features.Pizzas;
using Pizzaria.Domain.Features.Sabores;
using Pizzaria.Features.Sabores;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Pizzas;
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

namespace Pizzaria.Features.Pizzas
{
    public partial class PizzaPopUp : Form
    {
        Pizza _pizza;
        Sabor _sabor;
        private IPizzaServico _pizzaServico;
        public PizzaPopUp(Pizza pizza = null)
        {
            InitializeComponent();

            if (pizza != null)
                this._pizza = pizza;
            else
                _pizza = new Pizza();

            var contexto = new PizzariaContext();
            var repositorio = new PizzaRepositorio(contexto);
            var saborRepositorio = new SaborRepositorio(contexto);
            _pizzaServico = new PizzaServico(repositorio, saborRepositorio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaborPopUp saborPopUp = new SaborPopUp(TipoSabor.Pizza);
            saborPopUp.ShowDialog();

            if (saborPopUp.DialogResult == DialogResult.OK)
            {
                this._sabor = saborPopUp.Sabor;
                textBoxSabor.Text = _sabor.Descricao;
            }
        }

        private void HabilitarDesabilitarValor(NumericUpDown numericUpDown, Label label, bool habilitar)
        {
            if (habilitar)
            {
                numericUpDown.Visible = true;
                label.Visible = true;
            }
            else
            {
                numericUpDown.Visible = false;
                label.Visible = false;
            }
        }

        private void checkBoxPequena_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPequena.Checked)
                HabilitarDesabilitarValor(valorPequena, labelValorPequena, true);
            else
                HabilitarDesabilitarValor(valorPequena, labelValorPequena, false);
        }

        private void checkBoxMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMedia.Checked)
                HabilitarDesabilitarValor(valorMedia, labelValorMedia, true);
            else
                HabilitarDesabilitarValor(valorMedia, labelValorMedia, false);

        }

        private void checkBoxGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrande.Checked)
                HabilitarDesabilitarValor(valorGrande, labelValorGrande, true);
            else
                HabilitarDesabilitarValor(valorGrande, labelValorGrande, false);
        }

        private void checkBoxGigante_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGigante.Checked)
                HabilitarDesabilitarValor(valorGigante, labelValorGigante, true);
            else
                HabilitarDesabilitarValor(valorGigante, labelValorGigante, false);
        }

        private void checkBoxExtraGigante_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtraGigante.Checked)
                HabilitarDesabilitarValor(valorExtraGigante, labelValorExtraGigante, true);
            else
                HabilitarDesabilitarValor(valorExtraGigante, labelValorExtraGigante, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_sabor == null)
            {
                MessageBox.Show("Selecione um sabor");
                return;
            }

            var pizzas = this.GerenciarPizza();

            if (pizzas != null)
                try
                {
                    _pizzaServico.AddLista(pizzas);
                    buttonSalvar.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar:" + ex.Message);
                    buttonSalvar.DialogResult = DialogResult.None;
                }

        }

        private List<Pizza> GerenciarPizza()
        {
            var pizzas = new List<Pizza>();

            if (checkBoxPequena.Checked)
            {
                var pizza = new Pizza();
                pizza.TamanhoPizza = TamanhoPizza.Pequena;
                var valor = valorPequena.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor da pizza pequena não pode ser menor que R$ 1,00");
                    return null;
                }
                pizza.Valor = Convert.ToDouble(valor);
                pizzas.Add(pizza);
            }
            if (checkBoxMedia.Checked)
            {
                var pizza = new Pizza();
                pizza.TamanhoPizza = TamanhoPizza.Media;
                var valor = valorMedia.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor da pizza media não pode ser menor que R$ 1,00");
                    return null;
                }
                pizza.Valor = Convert.ToDouble(valor);
                pizzas.Add(pizza);
            }

            if (checkBoxGrande.Checked)
            {
                var pizza = new Pizza();
                pizza.TamanhoPizza = TamanhoPizza.Grande;
                var valor = valorGrande.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor de pizza grande não pode ser menor que R$ 1,00");
                    return null;
                }
                pizza.Valor = Convert.ToDouble(valor);
                pizzas.Add(pizza);
            }

            if (checkBoxGigante.Checked)
            {
                var pizza = new Pizza();
                pizza.TamanhoPizza = TamanhoPizza.Gigante;
                var valor = valorGigante.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor de pizza gigante não pode ser menor que R$ 1,00");
                    return null;
                }
                pizza.Valor = Convert.ToDouble(valor);
                pizzas.Add(pizza);
            }

            if (checkBoxExtraGigante.Checked)
            {
                var pizza = new Pizza();
                pizza.TamanhoPizza = TamanhoPizza.ExtraGigante;
                var valor = valorExtraGigante.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor de pizza extra gigante não pode ser menor que R$ 1,00");
                    return null;
                }
                pizza.Valor = Convert.ToDouble(valor);
                pizzas.Add(pizza);
            }

            foreach (var item in pizzas)
            {
                item.AdicionarSabor(_sabor);
            }


            return pizzas;
        }

    }
}
