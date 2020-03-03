using AutoMapper;
using Produtos.Aplicacao.DTO;
using Produtos.Aplicacao.Interfaces;
using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Servicos;

namespace Produtos.Aplicacao.Servicos
{
    public class ProdutoApp : ServicoAppBase<Produto, ProdutoDTO>, IProdutoApp
    {
        public ProdutoApp(IMapper iMapper, IProdutoServico servico) : base(iMapper, servico)
        {
        }
    }
}
