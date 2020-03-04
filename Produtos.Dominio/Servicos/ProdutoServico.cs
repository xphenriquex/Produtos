using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Repositorios;
using Produtos.Dominio.Interfaces.Servicos;

namespace Produtos.Dominio.Servicos
{
    public class ProdutoServico : ServicoBase<Produto>, IProdutoServico
    {
        public ProdutoServico(IProdutoRepositorio repositorio) : base(repositorio)
        {
        }
    }
}
