using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aplicacao02.Models
{
    public class Fornecedor
    {
        [Key]
        public int IDFornecedor { get; set; }

        [Required]
        [Display(Name = "Nome Fornecedor")]
        public string NomeFornecedor { get; set; }        

    }
}