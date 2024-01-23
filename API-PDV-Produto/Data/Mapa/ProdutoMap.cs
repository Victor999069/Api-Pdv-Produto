using API_PDV_Produto.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PDV_Produto.Data.Mapa
{
    public class ProdutoMap : IEntityTypeConfiguration<ModelProduto>
    {
        public void Configure(EntityTypeBuilder<ModelProduto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Fornecedor).IsRequired().HasMaxLength(300);
        }

    }
}
