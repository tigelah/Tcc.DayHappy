using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Eventos;

namespace Tcc.DayHappy.Dominio.StatusEntregas
{
    public class StatusEntrega : Entity
    {
        public Evento CodEvento { get; private set; }
        public string DescricaoProblema { get; private set; }
        public string NivelProblema { get; private set; }
        public string SituacaoEntrega { get; private set; }

        protected StatusEntrega() { }

        //Lembrar dos tratamentos das DATAS 
        public StatusEntrega(Evento codEvento, string descricaoProblema, string nivelProblema, string situacaoEntrega)
        {
            ValidacaoValoresSetPropriedades(codEvento, descricaoProblema, nivelProblema, situacaoEntrega);
        }

        private void ValidacaoValoresSetPropriedades(Evento codEvento, string descricaoProblema, string nivelProblema, string situacaoEntrega)
        {
            DomainException.Quando(codEvento == null, "Orçamento não foi completado corretamente");
            DomainException.Quando(string.IsNullOrEmpty(descricaoProblema), "Status Digitado Invalido");
            DomainException.Quando(descricaoProblema.Length <= 1, "Status Invalido");
            DomainException.Quando(string.IsNullOrEmpty(nivelProblema), "Status Digitado Invalido");
            DomainException.Quando(nivelProblema.Length <= 1, "Status Invalido");
            DomainException.Quando(string.IsNullOrEmpty(situacaoEntrega), "Status Digitado Invalido");
            DomainException.Quando(situacaoEntrega.Length <= 1, "Status Invalido");

            CodEvento = codEvento;
            SituacaoEntrega = situacaoEntrega;
            DescricaoProblema = descricaoProblema;
            NivelProblema = nivelProblema;
        }

        public void Update(Evento codEvento, string descricaoProblema, string nivelProblema, string situacaoEntrega)
        {
            ValidacaoValoresSetPropriedades(codEvento, descricaoProblema, nivelProblema, situacaoEntrega);
        }


    }

    
}
