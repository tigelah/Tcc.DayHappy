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

        public void Armazenar(int id, string representante, string nomeEmpresa, string cnpj, string inscEstadual, int contato1, string cep,
                    string logradouro, string numero, string bairro, string cidade, int contato2, string email)
        {
            var pessoaJuridica = _pessoaJuridicaRepository.GetById(id);

            if(pessoaJuridica == null)
            {
                pessoaJuridica = new PessoaJuridica(representante, nomeEmpresa, cnpj, inscEstadual,contato1, cep,logradouro, numero,  bairro,  cidade,  contato2,  email);
                _pessoaJuridicaRepository.Save(pessoaJuridica);
            }
            else
            {
                pessoaJuridica.Update(representante, nomeEmpresa, cnpj, inscEstadual, contato1, cep, logradouro, numero, bairro, cidade, contato2, email);
            } 
               
        }

    }
}
