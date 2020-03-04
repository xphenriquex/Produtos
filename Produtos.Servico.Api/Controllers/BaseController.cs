using Microsoft.AspNetCore.Mvc;
using System;
using Produtos.Dominio.Entidades;
using Produtos.Aplicacao.DTO;
using Produtos.Aplicacao.Interfaces;

namespace Produtos.Servico.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class BaseController<Entidade, EntidadeDTO> : Controller
        where Entidade : EntidadeBase
        where EntidadeDTO : DTOBase
    {
        readonly protected IAppbase<Entidade, EntidadeDTO> app;

        public BaseController(IAppbase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var produtos = app.SelecionarTodos();
                return new OkObjectResult(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                var produtos = app.SelecionarPorId(id);
                return new OkObjectResult(produtos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] EntidadeDTO dado)
        {
            try
            {
                return new OkObjectResult(app.Incluir(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] EntidadeDTO dado)
        {
            try
            {
                app.Alterar(dado);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpDelete]
        //[Route("{id}")]
        //public IActionResult Excluir(int id)
        //{
        //    try
        //    {
        //        app.Excluir(id);
        //        return new OkObjectResult(true);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}