using Produtos.Aplicacao.DTO;
using Produtos.Aplicacao.Interfaces;
using Produtos.Dominio.Entidades;

namespace Produtos.Servico.Api.Controllers
{
    public class ProdutosController : BaseController<Produto, ProdutoDTO>
    {
        public ProdutosController(IProdutoApp app) : base(app)
        {

        }
    }
}