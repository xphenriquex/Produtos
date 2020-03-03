using Produtos.Aplicacao.DTO;
using Produtos.Dominio.Entidades;
using System.Threading.Tasks;

namespace Produtos.Aplicacao.Interfaces
{
    public interface IAppbase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : DTOBase
    {
        void Cadastrar(TEntidadeDTO entity);
        void Atualizar(TEntidadeDTO entity);
        void Deletar(TEntidadeDTO entity);
    }
}
