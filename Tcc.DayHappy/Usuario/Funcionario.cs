using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Usuario
{
    public class Funcionario :Entity
    {
        public DateTime DataNasc { get; private set; }
        public string NomeCargo { get; private set; }
        public decimal Salario { get; private set; }
        public DateTime DataAdm { get; private set; }
        public string Referencia { get; private set; }
        public virtual Pessoa Pessoa { get; private set; }
        public virtual Contato Contato { get; private set; }

        protected Funcionario() { }

        public Funcionario (string nomeCargo, decimal salario,DateTime dataAdm, Pessoa pessoa, Contato contato,string referencia)
        {
            ValidacaoValoresSetPropriedades(nomeCargo, salario, dataAdm, pessoa , contato);
            Referencia = referencia;
        }
        //Lembrar de rever todos os tratamentos 
        private void ValidacaoValoresSetPropriedades(string nomeCargo, decimal salario, DateTime dataAdm, Pessoa pessoa, Contato contato)
        {
            DomainException.Quando(string.IsNullOrEmpty(nomeCargo), "Cargo Digitado Invalido");
            DomainException.Quando(salario <= 0, "Salario invalido");
            DomainException.Quando(contato == null, "Digite os campos corretamente");
            DomainException.Quando(pessoa == null, "Digite os campos corretamente");
            NomeCargo = nomeCargo;
            Salario = salario;
            DataAdm = dataAdm;
            Pessoa = pessoa;
            Contato = contato;


        }
         
        public void Update(string nomeCargo, decimal salario, DateTime dataAdm, Pessoa pessoa, Contato contato, string referencia)
        {
            ValidacaoValoresSetPropriedades(nomeCargo, salario, dataAdm, pessoa, contato);
            Referencia = referencia;
        }

    }
}
