﻿
using System.ComponentModel.DataAnnotations;


namespace ApiProduto.Data
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        
        [Required]
        public decimal Preco { get; set; }
       
        [Required]
        public int Estoque { get; set; }
    }
}
