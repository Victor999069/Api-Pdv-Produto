using API_PDV_Produto.Model;
using API_PDV_Produto.Controllers;

namespace API_PDV_Produto.Repositorio.Interface
{
    public interface UIproduto
    {
        Task<List<ModelProduto>> BuscarTodosProdutos();
        Task<ModelProduto> BuscarId(int id);
        Task<ModelProduto> Adicionar(ModelProduto produto);
        Task<ModelProduto> Atualizar(ModelProduto produto, int id);
        Task<bool> Apagar(int id);
    }
}
