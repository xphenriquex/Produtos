using Produtos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Produtos.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase
    {
        void Cadastrar(TEntidade entity);
        void Atualizar(TEntidade entity);
        void Deletar(TEntidade entity);
        Task<TEntidade> SalvarAsync(TEntidade entity);
    }
}
