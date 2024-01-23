using API_PDV_Produto.Data;
using API_PDV_Produto.Model;
using Microsoft.EntityFrameworkCore;

namespace API_PDV_Produto.Repositorio
{
    public class ProdutoRepo
    {
        private readonly SistemaTarefaDB _dbContext;
        public ProdutoRepo(SistemaTarefaDB SistemaTarefaDB)
        {
            _dbContext = SistemaTarefaDB;
        }
        public async Task<ModelProduto> BuscarId(int id)
        {
            return await _dbContext.Produtos.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
