using AutoMapper;
using Produtos.Aplicacao.DTO;
using Produtos.Dominio.Entidades;

namespace Produtos.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Produto, ProdutoDTO>();
            CreateMap<ProdutoDTO, Produto>();
        }
    }
}
