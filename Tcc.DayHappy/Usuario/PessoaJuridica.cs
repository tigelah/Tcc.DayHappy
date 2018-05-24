using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Usuario
{
    public class PessoaJuridica : Entity
    {
        public string RAZAO_SOCIAL { get; set; }
        public string NOME_REPRESENTANTE { get; private set; }
        public string NOME_FANTASIA { get; private set; }
        public string CNPJ { get; private set; }
        public string INSCRICAO_ESTADUAL { get; private set; }
        public string SENHA_PES_JUR { get; set; }


        protected PessoaJuridica() { }

        public PessoaJuridica(string razaoSocial,string representante, string nomeFantasia, string cnpj, string inscEstadual,string Senha )
        {
            ValidacaoValoresSetPropriedades(razaoSocial,representante,nomeFantasia,  cnpj, inscEstadual);
            SENHA_PES_JUR = "SENHA";
        }
        public PessoaJuridica(string razaoSocial, string representante, string nomeFantasia, string cnpj, string inscEstadual)
        {
            ValidacaoValoresSetPropriedades(razaoSocial, representante, nomeFantasia, cnpj, inscEstadual);
            SENHA_PES_JUR = "SENHA";
        }
        //Lembrar dos tratamentos de rever todos
        private void ValidacaoValoresSetPropriedades(string razaoSocial, string representante, string nomeFantasia, string cnpj, string inscEstadual)
        {
            DomainException.Quando(string.IsNullOrEmpty(representante), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(nomeFantasia), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cnpj), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(inscEstadual), "Nome Representante Invalido");

            
            RAZAO_SOCIAL = razaoSocial;
            NOME_REPRESENTANTE = representante;
            NOME_FANTASIA = nomeFantasia;
            CNPJ = cnpj;
            INSCRICAO_ESTADUAL = inscEstadual;

           

        }

        public void Update(string razaoSocial, string representante, string nomeFantasia, string cnpj, string inscEstadual)
        {
            ValidacaoValoresSetPropriedades(razaoSocial, representante, nomeFantasia, cnpj, inscEstadual);
        }

    }
}
