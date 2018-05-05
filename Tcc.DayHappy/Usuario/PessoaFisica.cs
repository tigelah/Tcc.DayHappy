using System;
using System.Collections.Generic;
using System.Text;


namespace Tcc.DayHappy.Dominio.Usuario
{
   public class PessoaFisica : Entity
    {
        public virtual Pessoa Pessoa {get; private set; }
        public string Referencia { get; private set; }
        public virtual Contato Contato { get; private set; }

        protected PessoaFisica() {}

        public PessoaFisica(Pessoa pessoas, Contato contato, string referencia)
        {
            ValidacaoValoresSetPropriedades(pessoas,contato);
            Referencia = referencia;
        }
        //Lembrar de rever todos os tratamentos 
        private  void ValidacaoValoresSetPropriedades(Pessoa pessoa, Contato contato)
        {
            DomainException.Quando(pessoa == null, "Preencha os Campos Obrigatorios! !");
            DomainException.Quando(contato == null, "Preencha os Campos Obrigatorios! !");
            Pessoa = pessoa;
            Contato = contato;
        }

        public void Update(Pessoa pessoa, Contato contato, string referencia)
        {
            ValidacaoValoresSetPropriedades(pessoa,contato);
            Referencia = referencia;
        }
    }
}
