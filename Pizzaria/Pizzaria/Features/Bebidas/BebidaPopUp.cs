using Pizzaria.Aplicacao.Features.Bebidas;
using Pizzaria.Domain.Features.Bebidas;
using Pizzaria.Domain.Features.Sabores;
using Pizzaria.Features.Sabores;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Bebidas;
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

namespace Pizzaria.Features.Bebidas
{
    public partial class BebidaPopUp : Form
    {
        Bebida _bebida;
        private Sabor _sabor;
        private IBebidaServico _bebidaServico;
        public BebidaPopUp(Bebida bebida = null)
        {
            InitializeComponent();

            if (bebida != null)
                this._bebida = bebida;
            else
                bebida = new Bebida();

            var context = new PizzariaContext();
            var bebidaRepositorio = new BebidaRepositorio(context);
            var saborRepositorio = new SaborRepositorio(context);
            _bebidaServico = new BebidaServico(bebidaRepositorio, saborRepositorio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaborPopUp saborPopUp = new SaborPopUp(TipoSabor.Bebida);
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

        private void checkBoxLata_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLata.Checked)
                HabilitarDesabilitarValor(valorLata, labelValorLata, true);
            else
                HabilitarDesabilitarValor(valorLata, labelValorLata, false);
        }

        private void checkBoxGarrafa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGarrafa.Checked)
                HabilitarDesabilitarValor(valorGarrafa, labelValorGarrafa, true);
            else
                HabilitarDesabilitarValor(valorGarrafa, labelValorGarrafa, false);
        }

        private void checkBoxLitro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLitro.Checked)
                HabilitarDesabilitarValor(valorLitro, labelValorLitro, true);
            else
                HabilitarDesabilitarValor(valorLitro, labelValorLitro, false);
        }

        private void checkBoxLitrao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLitrao.Checked)
                HabilitarDesabilitarValor(valorLitrao, labelValorLitrao, true);
            else
                HabilitarDesabilitarValor(valorLitrao, labelValorLitrao, false);
        }

        private List<Bebida> GerenciarBebidas()
        {
            var bebidas = new List<Bebida>();

            if (checkBoxLata.Checked)
            {
                var bebida = new Bebida();
                bebida.TamanhoBebida = TamanhoBebida.Lata;
                var valor = valorLata.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor da bebida lata não pode ser menor que R$ 1,00");
                    return null;
                }
                bebida.Valor = Convert.ToDouble(valor);
                bebidas.Add(bebida);
            }

            if (checkBoxGarrafa.Checked)
            {
                var bebida = new Bebida();
                bebida.TamanhoBebida = TamanhoBebida.Garrafa;
                var valor = valorGarrafa.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor da bebida Garrafa não pode ser menor que R$ 1,00");
                    return null;
                }
                bebida.Valor = Convert.ToDouble(valor);
                bebidas.Add(bebida);
            }

            if (checkBoxLitro.Checked)
            {
                var bebida = new Bebida();
                bebida.TamanhoBebida = TamanhoBebida.Litro;
                var valor = valorLitro.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor da bebida Litro não pode ser menor que R$ 1,00");
                    return null;
                }
                bebida.Valor = Convert.ToDouble(valor);
                bebidas.Add(bebida);
            }

            if (checkBoxLitrao.Checked)
            {
                var bebida = new Bebida();
                bebida.TamanhoBebida = TamanhoBebida.Litrao;
                var valor = valorLitrao.Value;
                if (valor < 1)
                {
                    MessageBox.Show("Valor da bebida Litrao não pode ser menor que R$ 1,00");
                    return null;
                }
                bebida.Valor = Convert.ToDouble(valor);
                bebidas.Add(bebida);
            }


            foreach (var item in bebidas)
            {
                item.Sabor = _sabor;
            }


            return bebidas;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (_sabor == null)
            {
                MessageBox.Show("Selecione um sabor");
                return;
            }

            var bebidas = this.GerenciarBebidas();

            if (bebidas != null)
                try
                {
                    _bebidaServico.AddLista(bebidas);
                    buttonSalvar.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar:" + ex.Message);
                    buttonSalvar.DialogResult = DialogResult.None;
                }
        }
    }
}
