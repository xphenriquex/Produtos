using AutoMapper;
using Produtos.Aplicacao.DTO;
using Produtos.Aplicacao.Interfaces;
using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

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

        public void Alterar(TEntidadeDTO entidade)
        {
            _servico.Alterar(_iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            _servico.Excluir(_iMapper.Map<TEntidade>(entidade));
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            return _servico.Incluir(_iMapper.Map<TEntidade>(entidade));
        }

        public TEntidadeDTO SelecionarPorId(int id)
        {
            return _iMapper.Map<TEntidadeDTO>(_servico.SelecionarPorId(id));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            return _iMapper.Map<IEnumerable<TEntidadeDTO>>(_servico.SelecionarTodos());
        }

    }
}
