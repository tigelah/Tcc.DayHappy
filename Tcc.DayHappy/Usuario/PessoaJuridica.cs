using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Usuario
{
   public class PessoaJuridica : Entity
    {
        public string Representante { get; private set; }
        public string NomeEmpresa { get; private set; }
        public string Cnpj { get; private set; }
        public string InscEstadual { get; private set; }
        public virtual Contato Contato { get; private set; }

        protected PessoaJuridica() { }

        public PessoaJuridica(string representante, string nomeEmpresa, string cnpj, string inscEstadual , Contato contato)
        {
            ValidacaoValoresSetPropriedades(representante, nomeEmpresa, cnpj, inscEstadual,contato);
        }
        //Lembrar dos tratamentos
        private void ValidacaoValoresSetPropriedades(string representante, string nomeEmpresa, string cnpj, string inscEstadual, Contato contato)
        {
            DomainException.Quando(string.IsNullOrEmpty(representante), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(nomeEmpresa), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cnpj), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(inscEstadual), "Nome Representante Invalido");
            DomainException.Quando(contato == null, "Preencha os campos Corretamente");
            Representante = representante;
            NomeEmpresa = nomeEmpresa;
            Cnpj = cnpj;
            InscEstadual = inscEstadual;
            Contato = contato;


        }

        public void Update(string representante, string nomeEmpresa, string cnpj, string inscEstadual, Contato contato)
        {
            ValidacaoValoresSetPropriedades(representante, nomeEmpresa, cnpj, inscEstadual,contato);
        }

    }
}
