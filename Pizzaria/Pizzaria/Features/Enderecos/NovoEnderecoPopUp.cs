using Pizzaria.Aplicacao.Features.Enderecos;
using Pizzaria.Domain.Features.Enderecos;
using Pizzaria.Infra.CEP;
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
    public partial class NovoEnderecoPopUp : Form
    {
        private IEnderecoServico _enderecoServico;
        public NovoEnderecoPopUp()
        {
            InitializeComponent();
            var repositorio = new EnderecoRepositorio(new PizzariaContext());
            _enderecoServico = new EnderecoServico(repositorio);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var endereco = ValidarCep.BuscarCep(txtGetCep.Text);

            this.PopularEndereco(endereco);
        }

        private void PopularEndereco(Endereco endereco)
        {
            textBoxBairro.Text = endereco.Bairro;
            textBoxCity.Text = endereco.Cidade;
            txtEstado.Text = endereco.Estado;
            textBoxRua.Text = endereco.Rua;
        }

        private Endereco ConverterParaObjeto()
        {
            Endereco endereco = new Endereco();
            endereco.Bairro = textBoxBairro.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Rua = textBoxRua.Text;
            endereco.Numero = Convert.ToInt32(nupNumber.Value);
            endereco.Cidade = textBoxCity.Text;
            endereco.CEP = txtGetCep.Text;
            return endereco;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _enderecoServico.Add(ConverterParaObjeto());
                buttonSalvar.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonSalvar.DialogResult = DialogResult.None;
            }
        }
    }
}
