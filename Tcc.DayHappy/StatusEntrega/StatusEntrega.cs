using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Eventos;

namespace Tcc.DayHappy.Dominio.StatusEntrega
{
    public class StatusEntrega : Entity
    {
        public Evento CodEvento { get; private set; }
        public string DescricaoProblema { get; private set; }
        public string NivelProblema { get; private set; }
        public string SituacaoEntrega { get; private set; }

    }
}
