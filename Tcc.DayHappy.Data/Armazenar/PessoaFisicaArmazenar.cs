using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Dominio.Storer
{
   public class PessoaFisicaArmazenar 
    {
        private readonly IRepository<PessoaFisica> _pessoaFisicaRepository;

        public PessoaFisicaArmazenar(IRepository<PessoaFisica> pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }

        public void Armazenar(int id, string nome, DateTime dataNasc, string sexo, string cpf, string rg)
        {
            var pessoaFisica = _pessoaFisicaRepository.GetById(id);

            if(pessoaFisica == null)
            {
                pessoaFisica = new PessoaFisica(nome,dataNasc,sexo,cpf,rg);
                _pessoaFisicaRepository.Create(pessoaFisica);
            }
            else
            {
                pessoaFisica.Update(nome, dataNasc, sexo, cpf, rg);
            }
        }
        public void Deletar(int id, string nome, DateTime dataNasc, string sexo, string cpf, string rg, string referencia, int contato1, string cep, 
            string logradouro,string numero, string bairro, string cidade, int contato2, string email)
        {
            var pessoaFisica = _pessoaFisicaRepository.GetById(id);

            if (pessoaFisica.Id == id)
            {
                _pessoaFisicaRepository.Delete(pessoaFisica);
            }

        }


    }
}
