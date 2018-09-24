using Pizzaria.Aplicacao.Features.Sabores;
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

namespace Pizzaria.Features.Sabores
{
    public partial class SaborPopUp : Form
    {
        private TipoSabor _tipoEntrada;
        private ISaborServico _saborServico;
        public Sabor Sabor { get; set; }
        private List<Sabor> _listaSabores;
        public SaborPopUp(TipoSabor tipoEntrada)
        {
            InitializeComponent();
            this._tipoEntrada = tipoEntrada;
            var repositorio = new SaborRepositorio(new PizzariaContext());
            this._saborServico = new SaborServico(repositorio);
            dataGridViewSabores.AutoGenerateColumns = true;
            this.AtualizarLista(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selecionado = dataGridViewSabores.CurrentRow.DataBoundItem as Sabor;

            if (selecionado == null)
            {
                MessageBox.Show("Selecione um sabor");
                return;
            }
            else
            {
                Sabor = selecionado;
                DialogResult = DialogResult.OK;
            }
        }

        private void AtualizarLista(bool ehListaCompleta)
        {
            if(ehListaCompleta == true)
                _listaSabores = _saborServico.GetAllPorTipo(_tipoEntrada);
            if (_listaSabores == null)
                return;

            dataGridViewSabores.DataSource = null;
            dataGridViewSabores.DataSource = _listaSabores;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NovoSaborPopUp novoSaborPopUp = new NovoSaborPopUp(_tipoEntrada);
            novoSaborPopUp.ShowDialog();
            this.AtualizarLista(true);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _listaSabores = _saborServico.ObterPorDescricao(textBoxSabor.Text, _tipoEntrada);
            this.AtualizarLista(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.AtualizarLista(true);
            textBoxSabor.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
