using AutoMapper;
using Produtos.Aplicacao.DTO;
using Produtos.Aplicacao.Interfaces;
using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Aplicacao.Servicos
{
    public class ServicoAppBase<TEntidade, TEntidadeDTO> : IAppbase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : DTOBase
    {

        protected readonly IServicoBase<TEntidade> _servico;
        protected readonly IMapper _iMapper;

        public ServicoAppBase(IMapper IMapper, IServicoBase<TEntidade> servico)
        {
            _servico = servico;
            _iMapper = IMapper;
        }

        public void Atualizar(TEntidadeDTO entity)
        {
            _servico.Atualizar(_iMapper.Map<TEntidade>(entity));
        }

        public void Cadastrar(TEntidadeDTO entity)
        {
            _servico.Cadastrar(_iMapper.Map<TEntidade>(entity));
        }

        public void Deletar(TEntidadeDTO entity)
        {
            _servico.Deletar(_iMapper.Map<TEntidade>(entity));
        }

    }
}
