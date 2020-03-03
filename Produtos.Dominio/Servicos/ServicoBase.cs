using Produtos.Dominio.Entidades;
using Produtos.Dominio.Interfaces.Repositorios;
using Produtos.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly IRepositorioBase<TEntidade> _repo;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repo = repositorio;
        }

        public void Atualizar(TEntidade entity)
        {
            _repo.Atualizar(entity);
        }

        public void Cadastrar(TEntidade entity)
        {
            _repo.Cadastrar(entity);
        }

        public void Deletar(TEntidade entity)
        {
            _repo.Deletar(entity);

        }

        public Task<TEntidade> SalvarAsync(TEntidade entity)
        {
            return _repo.SalvarAsync(entity);
        }
    }
}
