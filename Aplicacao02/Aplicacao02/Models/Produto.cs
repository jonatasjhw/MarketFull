using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacao02.Models
{
    public class Produto
    {

        [Key]
        public int IDProduto { get; set; }

        [Required]
        [Display(Name = "Nome Produto")]
        public string NomeProduto { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public string Preco { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        // Relacionamento
        [Required]
        public int IDFornecedor { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

    }
}