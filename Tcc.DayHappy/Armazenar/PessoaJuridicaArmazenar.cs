using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Dominio.Storer
{
    public class PessoaJuridicaArmazenar 
    {
        private readonly IRepository<PessoaJuridica> _pessoaJuridicaRepository;

        public PessoaJuridicaArmazenar( IRepository<PessoaJuridica> pessoaJuridicaRepository)
        {
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }

        public void Armazenar(int id, string representante, string nomeEmpresa, string cnpj, string inscEstadual, Contato contato)
        {
            var pessoaJuridica = _pessoaJuridicaRepository.GetById(id);

            if(pessoaJuridica == null)
            {
                pessoaJuridica = new PessoaJuridica(representante, nomeEmpresa, cnpj, inscEstadual, contato);
                _pessoaJuridicaRepository.Save(pessoaJuridica);
            }
            else
            {
                pessoaJuridica.Update(representante, nomeEmpresa, cnpj, inscEstadual, contato);
            } 
               
        }

    }
}
