using Microsoft.Extensions.DependencyInjection;
using Produtos.Aplicacao.Interfaces;
using Produtos.Aplicacao.Servicos;
using Produtos.Dominio.Interfaces.Repositorios;
using Produtos.Dominio.Interfaces.Servicos;
using Produtos.Dominio.Servicos;
using Produtos.Infra.Data.Repositorios;

namespace Produtos.Infra.IoC
{
    public class InjetorDepencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppbase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<IProdutoApp, ProdutoApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IProdutoServico, ProdutoServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

        }
    }
}
