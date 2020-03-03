using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Repositorios;
using Restaurante.Infra.Data.Contextos;


namespace Produtos.Infra.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
