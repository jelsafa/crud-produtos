using System;
using Microsoft.AspNetCore.Mvc;
using Produtos.DTOs;
using Produtos.Interfaces;

namespace Produtos.Controllers.APIs
{
    [Produces("application/json")]
    [Route("api/produto")]
    public class ProdutoApiController : Controller
    {
        private IProdutoDomain produtoDomain;

        public ProdutoApiController(IProdutoDomain produtoDomain)
        {
            this.produtoDomain = produtoDomain;
        }

        [HttpPost]
        public ObjectResult Post([FromBody] ProdutoDTO produto)
        {
            try
            {
                produtoDomain.AddUpdate(produto);
                return new ObjectResult("Produto inserido com sucesso!");
            }
            catch (Exception ex)
            {
                return new ObjectResult(ex);
            }
        }

        [HttpGet("{id}")]
        public ObjectResult Get(long id)
        {
            return new ObjectResult(produtoDomain.Get(id));
        }

        [HttpGet]
        public ObjectResult ListarProdutos()
        {
            return new ObjectResult(produtoDomain.GetAll());
        }

        [HttpDelete("{id}")]
        public ObjectResult Delete(long id)
        {
            return new ObjectResult(produtoDomain.Delete(id));
        }
    }
}