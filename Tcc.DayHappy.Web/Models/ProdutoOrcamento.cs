using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Models
{
    public class ProdutoOrcamento
    {
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
        public IEnumerable<OrcamentoViewModel> Orcamentos { get; set; }
    }
}
