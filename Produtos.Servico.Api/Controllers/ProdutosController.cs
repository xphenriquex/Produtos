using Microsoft.AspNetCore.Mvc;
using Produtos.Aplicacao.DTO;
using Produtos.Aplicacao.Interfaces;
using Produtos.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Produtos.Servico.Api.Controllers
{
    public class ProdutosController : BaseController<Produto, ProdutoDTO>
    {
        public ProdutosController(IProdutoApp app) : base(app)
        {

        }
        // GET: api/BlogPosts
        //[HttpGet]
        //public IEnumerable<> GetProduto()
        //{
        //    return _context.BlogPost.OrderByDescending(p => p.PostId);
        //}

    }
}