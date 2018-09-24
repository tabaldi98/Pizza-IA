using Pizzaria.Aplicacao.Features.Clientes;
using Pizzaria.Domain.Features.Clientes;
using Pizzaria.Features.Enderecos;
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

namespace Pizzaria.Features.Clientes
{
    public partial class ClientePopUp : Form
    {
        private Cliente _cliente;
        private IClienteServico _servico;

        public ClientePopUp(Cliente cliente = null)
        {
            InitializeComponent();
            this._cliente = cliente;
            var repositorio = new ClienteRepositorio(new PizzariaContext());
            this._servico = new ClienteServico(repositorio);

            if(cliente == null)
            {
                _cliente = new Cliente();
            }
            else
            {
                _cliente = cliente;
            }

            VerificarMaskTelefone();

        }

        private void VerificarMaskTelefone()
        {
            if (radioButtonCelular.Checked)
            {
                textBoxTelefone.Mask = "(00) 0 0000 - 0000";
            }

            if (radioButtonFixo.Checked)
            {
                textBoxTelefone.Mask = "(00) 0000 - 0000";
            }
        }

        private void radioButtonCelular_CheckedChanged(object sender, EventArgs e)
        {
            VerificarMaskTelefone();
        }

        private void radioButtonFixo_CheckedChanged(object sender, EventArgs e)
        {
            VerificarMaskTelefone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnderecoPopUp enderecoPopUp = new EnderecoPopUp();
            enderecoPopUp.ShowDialog();

            if (enderecoPopUp.DialogResult == DialogResult.OK)
            {
                this._cliente.Endereco = enderecoPopUp.Endereco;
                textBoxEndereco.Text = _cliente.Endereco.CEP + " "+ _cliente.Endereco.Cidade;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _servico.Add(this.ConverterParaObjeto());
                buttonSalvar.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonSalvar.DialogResult = DialogResult.None;
            }
        }

        private Cliente ConverterParaObjeto()
        {
            var cliente = new Cliente();
            cliente.Nome = textBoxNome.Text;
            cliente.Email = textBoxEmail.Text;
            cliente.Numero = textBoxTelefone.Text;
            cliente.Endereco = _cliente.Endereco;
            return cliente;
        }
    }
}
