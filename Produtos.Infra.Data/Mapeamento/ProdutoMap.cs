using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Produtos.Dominio.Entidades;

namespace Produtos.Infra.Data.Mapeamentos
{
    public class ProdutoMap : MapBase<Produto>
    {
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
            builder.ToTable("produto");
            builder.Property(c => c.Descricao).IsRequired().HasColumnName("Descricao").HasMaxLength(200);
            builder.Property(c => c.Marca).IsRequired().HasColumnName("Marca").HasMaxLength(100);
            builder.Property(c => c.NumeroLote).IsRequired().HasColumnName("NumeroLote");
            builder.Property(c => c.Preco).IsRequired().HasColumnName("Preco");
        }
    }
}