using AutoMapper;
using Produtos.Aplicacao.DTO;
using Produtos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

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
