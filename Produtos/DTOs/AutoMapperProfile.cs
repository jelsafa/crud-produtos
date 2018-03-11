using AutoMapper;
using Produtos.Models;

namespace Produtos.DTOs
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProdutoDTO, Produto>();
            CreateMap<Produto, ProdutoDTO>();
        }
    }
}
