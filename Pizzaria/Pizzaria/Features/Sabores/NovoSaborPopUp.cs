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
    public partial class NovoSaborPopUp : Form
    {
        private TipoSabor _tipoEntrada;
        private Sabor _sabor;
        private ISaborServico _saborServico;
        public NovoSaborPopUp(TipoSabor tipoEntrada)
        {
            InitializeComponent();
            _tipoEntrada = tipoEntrada;
            var repositorio = new SaborRepositorio(new PizzariaContext());
            _saborServico = new SaborServico(repositorio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoSabor = textBoxSabor.Text;
            if (textoSabor.Length < 4)
            {
                MessageBox.Show("Sabor deve ter no mínimo 4 caracteres");
                return;
            }

            _sabor = new Sabor();
            _sabor.Descricao = textoSabor;

            if (_tipoEntrada == TipoSabor.Pizza)
                _sabor.TipoSabor = TipoSabor.Pizza;
            else if (_tipoEntrada == TipoSabor.Bebida)
                _sabor.TipoSabor = TipoSabor.Bebida;

            try
            {
                _saborServico.Add(_sabor);
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }

        }
    }
}
