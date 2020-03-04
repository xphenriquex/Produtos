using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Repositorios;
using Produtos.Infra.Data.Contextos;


namespace Produtos.Infra.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
