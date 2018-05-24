using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Itinerarios;
using Tcc.DayHappy.Dominio.Orcamentos;

namespace Tcc.DayHappy.Dominio.Armazenar
{
    public class ItinerarioArmazenar
    {
        private readonly IRepository<Itinerario> _itinerarioRepository;

        public ItinerarioArmazenar(IRepository<Itinerario> itinerarioRepository)
        {
            _itinerarioRepository = itinerarioRepository;
        }

        public void Armazenar(int id ,string modeloCarro, string numCarro, DateTime horarioSaida, Orcamento orcamento)
        {
            var itinerario = _itinerarioRepository.GetById(id);

            if(itinerario == null)
            {
                itinerario = new Itinerario(modeloCarro, numCarro, horarioSaida, orcamento);
              //  _itinerarioRepository.Save(itinerario);
            }
            else
            {
                itinerario.Update(modeloCarro, numCarro, horarioSaida, orcamento);
            }
        }
    }
}
