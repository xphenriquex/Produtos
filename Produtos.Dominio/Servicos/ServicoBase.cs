using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Repositorios;
using Produtos.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace Produtos.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly IRepositorioBase<TEntidade> _repo;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repo = repositorio;
        }

        public void Alterar(TEntidade entidade)
        {
            _repo.Alterar(entidade);
        }

        public void Excluir(TEntidade entidade)
        {
            _repo.Excluir(entidade);
        }

        public int Incluir(TEntidade entidade)
        {
            return _repo.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return _repo.SelecionarTodos();
        }
    }
}
