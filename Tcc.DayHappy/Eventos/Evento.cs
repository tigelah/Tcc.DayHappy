using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Orcamentos;

namespace Tcc.DayHappy.Dominio.Eventos
{
    public class Evento : Entity
    {
        public virtual Orcamento CodOrcamento { get; private set; }

        protected Evento() { }

        public Evento(Orcamento codOrcamento)
        {
            ValidacaoValoresSetPropriedades(codOrcamento);
        }
        private void ValidacaoValoresSetPropriedades(Orcamento codOrcamento)
        {
            DomainException.Quando(codOrcamento == null, "Orçamento não foi completado corretamente");


            CodOrcamento = codOrcamento;
        }

        public void Update(Orcamento codOrcamento)
        {
            ValidacaoValoresSetPropriedades(codOrcamento);
        }
    }
 
}
