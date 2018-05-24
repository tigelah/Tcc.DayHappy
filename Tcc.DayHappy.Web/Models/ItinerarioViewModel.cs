using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Models
{
    public class ItinerarioViewModel
    {
        public string Modelocarro { get; set; }
        public string Numcarro { get;  set; }
        public DateTime HorarioSaida { get; set; }
        public IEnumerable<ProdutoViewModel> Orcamentos { get; set; }
    }
}
