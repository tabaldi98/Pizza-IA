using Pizzaria.Aplicacao.Features.Enderecos;
using Pizzaria.Domain.Features.Enderecos;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Enderecos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Features.Enderecos
{
    public partial class EnderecoPopUp : Form
    {
        public Endereco Endereco { get; set; }
        private List<Endereco> _listaEnderecos;
        private IEnderecoServico _enderecoServico;
        public EnderecoPopUp()
        {
            InitializeComponent();

            var repositorio = new EnderecoRepositorio(new PizzariaContext());
            this._enderecoServico = new EnderecoServico(repositorio);
            dataGridViewEnderecos.AutoGenerateColumns = true;
            this.AtualizarLista(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selecionado = dataGridViewEnderecos.CurrentRow.DataBoundItem as Endereco;

            if (selecionado == null)
            {
                MessageBox.Show("Selecione um endereço");
                return;
            }
            else
            {
                Endereco = selecionado;
                DialogResult = DialogResult.OK;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.AtualizarLista(true);
            textBoxCidade.Text = string.Empty;
        }

        private void AtualizarLista(bool ehListaCompleta)
        {
            if (ehListaCompleta == true)
                _listaEnderecos = _enderecoServico.GetAll();
            if (_listaEnderecos == null)
                return;

            dataGridViewEnderecos.DataSource = null;
            dataGridViewEnderecos.DataSource = _listaEnderecos;
        }

        private void textBoxCidade_TextChanged(object sender, EventArgs e)
        {
            _listaEnderecos = _enderecoServico.ObterPorCidade(textBoxCidade.Text);
            this.AtualizarLista(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NovoEnderecoPopUp novoEnderecoPopUp = new NovoEnderecoPopUp();
            novoEnderecoPopUp.ShowDialog();
            this.AtualizarLista(true);
        }
    }
}
