using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Models
{
    public class FormaPagamentoViewModel
    {
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
        public IEnumerable<OrcamentoViewModel> Orcamentos { get; set; }
        public string StatusPagamento { get;  set; } // Confirmar se esse campo não vai ser boleano
        public DateTime DataConfirmacaoPagamento { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorRestante { get; set; }
        public DateTime ValidadeConfirmacaoPagamento { get;  set; }
        
    }
}
