using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Dominio.Storer
{
   public class PessoaFisicaArmazenar 
    {
        private readonly IRepository<PessoaFisica> _pessoaFisicaRepository;

        public PessoaFisicaArmazenar( IRepository<PessoaFisica> pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }

        public void Armazenar(int id, Pessoa pessoa, Contato contato, string referencia)
        {
            var pessoaFisica = _pessoaFisicaRepository.GetById(id);

            if(pessoaFisica == null)
            {
                pessoaFisica = new PessoaFisica(pessoa, contato, referencia);
                _pessoaFisicaRepository.Save(pessoaFisica);
            }
            else
            {
                pessoaFisica.Update(pessoa, contato, referencia);
            }
        }
    }
}
