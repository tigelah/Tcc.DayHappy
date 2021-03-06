﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Usuario
{
    public class Funcionario : Entity
    {
        public string Nome { get; private set; }
        public DateTime DataNasc { get; private set; }
        public string Sexo { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public int Contato1 { get; private set; }
        public int Contato2 { get; private set; }
        public string Email { get; private set; }
        public string NomeCargo { get; private set; }
        public decimal Salario { get; private set; }
        public DateTime DataAdm { get; private set; }
        public string Referencia { get; private set; }

        protected Funcionario() { }

        public Funcionario (string nome, DateTime dataNasc, string sexo, string cpf, string rg,string nomeCargo, 
            decimal salario,DateTime dataAdm,string referencia, int contato1, string cep, string logradouro, 
            string numero, string bairro, string cidade, int contato2, string email)
        {
            ValidacaoValoresSetPropriedades(nome,dataNasc,sexo,cpf,rg,nomeCargo,salario, dataAdm,contato1,cep,logradouro,numero,bairro,cidade,contato2,email);
            Referencia = referencia;
        }
        //Lembrar de rever todos os tratamentos 
        private void ValidacaoValoresSetPropriedades(string nome, DateTime dataNasc, string sexo, string cpf, string rg, string nomeCargo,
            decimal salario, DateTime dataAdm, int contato1, string cep, string logradouro,
            string numero, string bairro, string cidade, int contato2, string email)
        {
            DomainException.Quando(string.IsNullOrEmpty(nome), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(sexo), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cpf), "Nome Representante Invalido");
            DomainException.Quando(cpf.Length <= 0, "Numero Invalido");
            DomainException.Quando(string.IsNullOrEmpty(rg), "Nome Representante Invalido");
            DomainException.Quando(cpf.Length <= 0, "Numero Invalido");
            DomainException.Quando(string.IsNullOrEmpty(nomeCargo), "Cargo Digitado Invalido");
            DomainException.Quando(salario <= 0, "Salario invalido");
            DomainException.Quando(string.IsNullOrEmpty(cep), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(logradouro), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(numero), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(bairro), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cidade), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(email), "Nome Representante Invalido");
            DomainException.Quando(string.IsNullOrEmpty(contato1.ToString()), "Nome Representante Invalido");
            DomainException.Quando(contato1 <= 0, "Salario invalido");
            DomainException.Quando(string.IsNullOrEmpty(contato1.ToString()), "Nome Representante Invalido");
            DomainException.Quando(contato1 <= 0, "Salario invalido");

            Nome = nome;
            DataNasc = dataNasc;
            Sexo = sexo;
            Cpf = cpf;
            Rg = rg;
            NomeCargo = nomeCargo;
            Salario = salario;
            DataAdm = dataAdm;
            Contato1 = contato1;
            Contato2 = contato2;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Email = email;




        }
         
        public void Update(string nome, DateTime dataNasc, string sexo, string cpf, string rg,string nomeCargo,
            decimal salario, DateTime dataAdm,string referencia, int contato1, string cep, string logradouro,
            string numero, string bairro, string cidade, int contato2, string email)
        {
            ValidacaoValoresSetPropriedades(nome, dataNasc, sexo, cpf, rg, nomeCargo, salario, dataAdm, contato1, cep, logradouro, numero, bairro, cidade, contato2, email);
             Referencia = referencia;
        }

}
}
