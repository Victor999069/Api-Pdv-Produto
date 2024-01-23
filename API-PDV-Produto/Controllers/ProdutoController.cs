using API_PDV_Produto.Model;
using API_PDV_Produto.Repositorio.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_PDV_Produto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly UIproduto _ProdutoRepo;

        public ProdutoController(UIproduto ProdutoRepo)
        {
            _ProdutoRepo = ProdutoRepo;
        }
        [HttpGet]
        public async Task<ActionResult<List<ModelProduto>>> BuscarProdutos()
        {
            List<ModelProduto> produtos = await _ProdutoRepo.BuscarTodosProdutos();
            return Ok();
        } 
    }
}
