using Produtos.Aplicacao.DTO;
using Produtos.Dominio.Entidades;

namespace Produtos.Aplicacao.Interfaces
{
    public interface IProdutoApp : IAppbase<Produto, ProdutoDTO>
    {
    }
}
