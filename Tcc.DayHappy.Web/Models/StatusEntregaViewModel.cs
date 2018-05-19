using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Models
{
    public class StatusEntregaViewModel
    {
        public IEnumerable<EventoViewModel> Eventos { get; set; }
        public string DescricaoProblema { get; set; }
        public string NivelProblema { get; set; }
        public string SituacaoEntrega { get; set; }
    }
}
