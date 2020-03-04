using Microsoft.EntityFrameworkCore;
using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Repositorios;
using Produtos.Infra.Data.Contextos;
using System.Collections.Generic;
using System.Linq;

namespace Produtos.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        protected readonly Contexto _contexto;
        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
        }


        public void Alterar(TEntidade entidade)
        {
            _contexto.InitTransacao();
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SendChanges();
        }

        public void Excluir(TEntidade entidade)
        {
            _contexto.InitTransacao();
            _contexto.Set<TEntidade>().Remove(entidade);
            _contexto.SendChanges();
        }

        public int Incluir(TEntidade entidade)
        {
            _contexto.InitTransacao();
            var id = _contexto.Set<TEntidade>().Add(entidade).Entity.Id;
            _contexto.SendChanges();
            return id;
        }

        public TEntidade SelecionarPorId(int id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return _contexto.Set<TEntidade>().ToList();
        }
    }

}
