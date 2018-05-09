using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Eventos;
using Tcc.DayHappy.Dominio.StatusEntregas;

namespace Tcc.DayHappy.Dominio.Armazenar
{
    class StatusEntregaArmazenar
    {
        private readonly IRepository<StatusEntrega> _statusEntregaRepository;

        public StatusEntregaArmazenar(IRepository<StatusEntrega> statusEntregaRepository)
        {
            _statusEntregaRepository = statusEntregaRepository;
        }

        public void Armarzenar (int id,Evento codEvento,string descricaoProblema,string nilvelProblema,string situacaoEntrega)
        {
            var statusEntrega = _statusEntregaRepository.GetById(id);

            if(statusEntrega == null)
            {
                statusEntrega = new StatusEntrega(codEvento, descricaoProblema, nilvelProblema, situacaoEntrega);
                _statusEntregaRepository.Save(statusEntrega);
            }
            else
            {
                statusEntrega.update(codEvento, descricaoProblema, nilvelProblema, situacaoEntrega);
            }



        }










    }
}
