using Pizzaria.Aplicacao.Features.Bebidas;
using Pizzaria.Base;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Bebidas;
using Pizzaria.Infra.ORM.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Features.Bebidas
{
    public class BebidaFormulario : GerenciadorFormulario
    {
        private IBebidaServico _servico;
        private BebidaPopUp _bebidaPopUp;
        private BebidaControl _bebidaControl;
        public BebidaFormulario()
        {
            var context = new PizzariaContext();
            var bebidaRepositorio = new BebidaRepositorio(context);
            var saborRepositorio = new SaborRepositorio(context);
            _servico = new BebidaServico(bebidaRepositorio, saborRepositorio);
            _bebidaControl = new BebidaControl();
            _bebidaPopUp = new BebidaPopUp();
        }

        public override void Adicionar()
        {
            BebidaPopUp cpp = new BebidaPopUp();
            cpp.ShowDialog();
            this.AtualizarLista();
        }

        public override void Atualizar()
        {
            var selecionado = _bebidaControl.ObterSelecionado();

            if (selecionado != null)
            {
                BebidaPopUp cpp = new BebidaPopUp(selecionado);
                cpp.ShowDialog();
                this.AtualizarLista();
            }
            else
            {
                MessageBox.Show("Selecione uma bebida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void AtualizarLista()
        {
            this._bebidaControl.AtualizarLista();
        }

        public override UserControl CarregarListagem()
        {
            return new BebidaControl();
        }

        public override void Remover()
        {
            var selected = _bebidaControl.ObterSelecionado();

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
                MessageBox.Show("Selecione uma bebida", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
