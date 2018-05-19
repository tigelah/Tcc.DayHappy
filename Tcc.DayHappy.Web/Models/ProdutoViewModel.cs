using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Models
{
    public class ProdutoViewModel
    {    
        public int Id { get; set; }
        [Required]
        public string NomeProduto { get; set; }
        public string FaixaEtaria { get;  set; }
        public string Descricao { get; set; }
        [Display(Name = "Nascimento"), DataType(DataType.Date),
         DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCompra { get; set; }
        public decimal ValorLocacao { get; set; }
        public decimal ValorCusto { get;  set; }
        public string CheckListPecas { get; set; }

    }
}
