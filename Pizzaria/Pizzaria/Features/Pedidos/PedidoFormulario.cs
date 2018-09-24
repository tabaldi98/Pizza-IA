using Pizzaria.Aplicacao.Features.Pedidos;
using Pizzaria.Base;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Ordens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Features.Pedidos
{
   public class PedidoFormulario : GerenciadorFormulario
    {
        private IPedidoServico _servico;
        private NovoPedidoForm _pedidoForm;
        private PedidoControl _pedidoControl;
        public PedidoFormulario()
        {
            var repositorio = new OrdemRepositorio(new PizzariaContext());
            _servico = new PedidoServico(repositorio);
            _pedidoControl = new PedidoControl();
            _pedidoForm = new NovoPedidoForm();
        }

        public override void Adicionar()
        {
            NovoPedidoForm cpp = new NovoPedidoForm();
            cpp.ShowDialog();
            this.AtualizarLista();
        }

        public override void Atualizar()
        {
            var selecionado = _pedidoControl.ObterSelecionado();

            if (selecionado != null)
            {
                NovoPedidoForm cpp = new NovoPedidoForm(selecionado);
                cpp.ShowDialog();
                this.AtualizarLista();
            }
            else
            {
                MessageBox.Show("Selecione um pedido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void AtualizarLista()
        {
            this._pedidoControl.AtualizarLista();
        }

        public override UserControl CarregarListagem()
        {
            return new PedidoControl();
        }

        public override void Remover()
        {
            var selected = _pedidoControl.ObterSelecionado();

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
                MessageBox.Show("Selecione um pedido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
