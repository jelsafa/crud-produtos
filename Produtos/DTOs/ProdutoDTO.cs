using System;

namespace Produtos.DTOs
{
    public class ProdutoDTO
    {
        public long Id { get; set; }
        public String Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
