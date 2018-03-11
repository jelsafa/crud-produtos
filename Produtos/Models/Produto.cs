using System;
using System.ComponentModel.DataAnnotations;

namespace Produtos.Models
{
    public class Produto
    {
        [Key]
        public long Id { get; set; }
        public String Nome { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
    }
}
