using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Eventos;
using Tcc.DayHappy.Dominio.Orcamentos;

namespace Tcc.DayHappy.Dominio.Armazenar
{
    public class EventoArmazenar
    {
        private readonly IRepository<Evento> _eventoRepository;

        public EventoArmazenar(IRepository<Evento> eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public void Armazenar(int id ,Orcamento CodOrcamento)
        {
            var evento = _eventoRepository.GetById(id);

            if(evento == null)
            {
                evento = new Evento(CodOrcamento);
                _eventoRepository.Save(evento);
            }
            else
            {
                evento.Update(CodOrcamento);
            }
        }
    }
}
