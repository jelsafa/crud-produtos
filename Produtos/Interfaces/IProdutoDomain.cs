using Produtos.DTOs;
using System.Collections.Generic;

namespace Produtos.Interfaces
{
    public interface IProdutoDomain
    {
        void AddUpdate(ProdutoDTO produto);

        bool Delete(long Id);

        ProdutoDTO Get(long Id);

        List<ProdutoDTO> GetAll();
    }
}
