using Pizzaria.Aplicacao.Features.Pizzas;
using Pizzaria.Base;
using Pizzaria.Infra.ORM.Base;
using Pizzaria.Infra.ORM.Features.Pizzas;
using Pizzaria.Infra.ORM.Features.Sabores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Features.Pizzas
{
    public class PizzaFormulario : GerenciadorFormulario
    {
        private IPizzaServico _servico;
        private PizzaPopUp _pizzaPopUp;
        private PizzaControl _pizzaControl;
        public PizzaFormulario()
        {
            var contexto = new PizzariaContext();
            var repositorio = new PizzaRepositorio(contexto);
            var saborRepositorio = new SaborRepositorio(contexto);
            _servico = new PizzaServico(repositorio, saborRepositorio);
            _pizzaControl = new PizzaControl();
            _pizzaPopUp = new PizzaPopUp();
        }

        public override void Adicionar()
        {
            PizzaPopUp cpp = new PizzaPopUp();
            cpp.ShowDialog();
            this.AtualizarLista();
        }

        public override void Atualizar()
        {
            var selecionado = _pizzaControl.ObterSelecionado();

            if (selecionado != null)
            {
                PizzaPopUp cpp = new PizzaPopUp(selecionado);
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
            this._pizzaControl.AtualizarLista();
        }

        public override UserControl CarregarListagem()
        {
            return new PizzaControl();
        }

        public override void Remover()
        {
            var selected = _pizzaControl.ObterSelecionado();

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
