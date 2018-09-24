using Pizzaria.Aplicacao.Features.Clientes;
using Pizzaria.Base;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Features.Clientes
{
    public class ClienteFormulario : GerenciadorFormulario
    {
        private IClienteServico _servico;
        private ClientePopUp _clientePop;
        private ClienteControl _clienteControl;
        public ClienteFormulario()
        {
            var repositorio = new ClienteRepositorio(new PizzariaContext());
            _servico = new ClienteServico(repositorio);
            _clienteControl = new ClienteControl();
            _clientePop = new ClientePopUp();
        }

        public override void Adicionar()
        {
            ClientePopUp cpp = new ClientePopUp();
            cpp.ShowDialog();
            this.AtualizarLista();
        }

        public override void Atualizar()
        {
            var selecionado = _clienteControl.ObterSelecionado();

            if (selecionado != null)
            {
                ClientePopUp cpp = new ClientePopUp(selecionado);
                cpp.ShowDialog();
                this.AtualizarLista();
            }
            else
            {
                MessageBox.Show("Selecione um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void AtualizarLista()
        {
            this._clienteControl.AtualizarLista();
        }

        public override UserControl CarregarListagem()
        {
            return new ClienteControl();
        }

        public override void Remover()
        {
            var selected = _clienteControl.ObterSelecionado();

            if (selected != null)
            {
                try
                {
                    var retorno = _servico.Remover(selected.ID);

                    if (retorno)
                        MessageBox.Show("Deletado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show("Erro ao deletar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    this.AtualizarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
