using Produtos.Aplicacao.DTO;
using Produtos.Dominio.Entidades;
using System.Collections.Generic;


namespace Produtos.Aplicacao.Interfaces
{
    public interface IAppbase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : DTOBase
    {
        int Incluir(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        TEntidade SelecionarPorId(int id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}
