using AutoMapper;
using Produtos.Aplicacao.DTO;
using Produtos.Aplicacao.Interfaces;
using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Servicos;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Produtos.Aplicacao.Servicos
{
    public class ProdutoApp : ServicoAppBase<Produto, ProdutoDTO>, IProdutoApp
    {
        public ProdutoApp(IMapper iMapper, IProdutoServico servico) : base(iMapper, servico)
        {

        }
    }
}
