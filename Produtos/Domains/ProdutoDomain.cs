using AutoMapper;
using Microsoft.Extensions.Logging;
using Produtos.DTOs;
using Produtos.Interfaces;
using Produtos.Models;
using System.Collections.Generic;
using System.Linq;

namespace Produtos.Domains
{
    public class ProdutoDomain : IProdutoDomain
    {
        protected MySqlDbContext context;
        protected ILogger logger;
        private IMapper mapper;

        public ProdutoDomain(MySqlDbContext context, ILoggerFactory loggerFactory, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddUpdate(ProdutoDTO produtoDTO)
        {
            Produto produto = mapper.Map<Produto>(produtoDTO);
            if (produto.Id == 0)
            {
                this.context.Produto.Add(produto);
            }
            else
            {
                this.context.Produto.Update(produto);
            }
            this.context.SaveChanges();
        }

        public bool Delete(long id)
        {
            Produto produto = context.Produto.FirstOrDefault(r => r.Id == id);
            if (produto == null)
                return false;

            context.Produto.Remove(produto);
            context.SaveChanges();
            return true;
        }

        public ProdutoDTO Get(long Id)
        {
            ProdutoDTO userDTO = mapper.Map<ProdutoDTO>(context.Produto.FirstOrDefault(r => r.Id == Id));
            return userDTO;
        }

        public List<ProdutoDTO> GetAll()
        {
            List<ProdutoDTO> list = mapper.Map<List<ProdutoDTO>>(context.Produto.ToList());
            return list;
        }
    }
}
