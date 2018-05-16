using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Usuario
{
   public class PessoaJuridica : Entity
    {
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public int Contato1 { get; private set; }
        public int Contato2 { get; private set; }
        public string Email { get; private set; }
        public string Representante { get; private set; }
        public string NomeEmpresa { get; private set; }
        public string Cnpj { get; private set; }
        public string InscEstadual { get; private set; }


        protected PessoaJuridica() { }

        public PessoaJuridica(string representante, string nomeEmpresa, string cnpj, string inscEstadual , int contato1,string cep,string logradouro,string numero,string bairro,string cidade,int contato2,string email)
        {
            ValidacaoValoresSetPropriedades(representante, nomeEmpresa, cnpj, inscEstadual,contato1, cep,logradouro, numero,  bairro,  cidade,  contato2,  email);
        }
        //Lembrar dos tratamentos de rever todos
        private void ValidacaoValoresSetPropriedades(string representante, string nomeEmpresa, string cnpj, string inscEstadual, int contato1, string cep, string logradouro, string numero, string bairro, string cidade, int contato2, string email)
        {
            DomainException.Quando(string.IsNullOrEmpty(representante), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(nomeEmpresa), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cnpj), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(inscEstadual), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cep), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(logradouro), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(numero), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(bairro), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cidade), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(email), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(contato1.ToString()), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(contato1.ToString()), "Nome Representante Invalido");

            Representante = representante;
            NomeEmpresa = nomeEmpresa;
            Cnpj = cnpj;
            InscEstadual = inscEstadual;
            Contato1 = contato1;
            Contato2 = contato2;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Email = email;

        }

        public void Update(string representante, string nomeEmpresa, string cnpj, string inscEstadual, int contato1, string cep, string logradouro, string numero, string bairro, string cidade, int contato2, string email)
        {
            ValidacaoValoresSetPropriedades(representante, nomeEmpresa, cnpj, inscEstadual, contato1, cep, logradouro, numero, bairro, cidade, contato2, email);
        }

    }
}
