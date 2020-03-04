using Produtos.Aplicacao.DTO;
using Produtos.Dominio.Entidades;
using System.Collections.Generic;


namespace Produtos.Aplicacao.Interfaces
{
    public interface IAppbase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : DTOBase
    {
        int Incluir(TEntidadeDTO entidade);
        void Excluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);
        TEntidadeDTO SelecionarPorId(int id);
        IEnumerable<TEntidadeDTO> SelecionarTodos();
    }
}
