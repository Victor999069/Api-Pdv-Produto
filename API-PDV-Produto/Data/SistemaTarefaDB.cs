using API_PDV_Produto.Data.Mapa;
using API_PDV_Produto.Model;
using Microsoft.EntityFrameworkCore;

namespace API_PDV_Produto.Data
{
    public class SistemaTarefaDB : DbContext
    {
        public SistemaTarefaDB(DbContextOptions<SistemaTarefaDB> options)
            : base(options) 
        { 
        
        }
        public DbSet<ModelProduto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
