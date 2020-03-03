using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Repositorios;

namespace Produtos.Dominio.Servicos
{
    public class ProdutoServico : ServicoBase<Produto>
    {
        public ProdutoServico(IProdutoRepositorio repositorio) : base(repositorio)
        {
        }
    }
}
