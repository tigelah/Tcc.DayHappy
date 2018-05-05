using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Orcamentos;

namespace Tcc.DayHappy.Dominio.Itinerarios
{
   public class Itinerario : Entity 
    {
        public string Modelocarro { get; private set; }
        public string Numcarro { get; private set; }
        public DateTime HorarioSaida { get; private set; }
        public virtual Orcamento Orcamento { get; private set; }
      
        protected Itinerario() { }

        public Itinerario(string modeloCarro, string numCarro, DateTime horarioSaida, Orcamento orcamento)
        {

            ValidacaoValoresSetPropriedades(modeloCarro, numCarro, horarioSaida, orcamento);
        }
        private void ValidacaoValoresSetPropriedades(string modeloCarro, string numCarro, DateTime horarioSaida, Orcamento orcamento)
        {
            DomainException.Quando(string.IsNullOrEmpty(modeloCarro), "Modelo do Carro Digitado Invalido");
            DomainException.Quando(string.IsNullOrEmpty(numCarro), "Numero do Carro Digitado Invalido");
            DomainException.Quando(orcamento == null, "Orçamento não foi completado corretamente");
            //tratar data 


            Orcamento = orcamento;
            Modelocarro = modeloCarro;
            Numcarro = numCarro;
            HorarioSaida = horarioSaida;
        }
        public void Update(string modeloCarro, string numCarro, DateTime horarioSaida, Orcamento orcamento)
        {
            ValidacaoValoresSetPropriedades( modeloCarro, numCarro, horarioSaida, orcamento);
        }

    }
}
