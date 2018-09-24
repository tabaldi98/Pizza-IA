using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Base
{
    public abstract class GerenciadorFormulario
    {
        public abstract void Adicionar();

        public abstract UserControl CarregarListagem();

        public abstract void Remover();

        public abstract void Atualizar();

        public abstract void AtualizarLista();
    }
}
