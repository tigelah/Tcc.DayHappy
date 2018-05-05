using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Orcamentos
{
   public class Orcamento : Entity
    {
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Referencia { get; private set; }
        public string Contato1 { get; private set; }
        public string Contato2 { get; private set; }
        public string Email { get; private set; }
        public DateTime DataEvento { get; private set; }
        public DateTime HorarioInicio { get; private set; }
        public DateTime HorarioTermino { get; private set; }
        public string TipoEvento { get; private set; }
        public decimal ValorFrete { get; private set; }
        public decimal ValorTotalServ { get; private set; }
        public decimal ValorTotalProd { get; private set; }
        public DateTime DataValidadeOrc { get; private set; }
        public string StatusOrc { get; private set; }

        protected Orcamento() { }

        public Orcamento(string cep, string logradouro, string numero, string bairro, string cidade, string referencia
            , string contato1, string contato2, string email, DateTime dataEvento, DateTime horarioInicio, DateTime horarioTermino, string tipoEvento
            , Decimal valorFrete, Decimal valorTotalServ, Decimal valorTotalProd, DateTime dataValidadeOrc, string statusOrc)
        {
            ValidacaoValoresSetPropriedades(cep, logradouro, numero, bairro, cidade, referencia
           , contato1, contato2, email, dataEvento, horarioInicio, horarioTermino, tipoEvento
           , valorFrete, valorTotalServ, valorTotalProd, dataValidadeOrc, statusOrc);
        }

        //Lembrar dos tratamentos das DATAS DE EVENTO HORARIO e VALIDADE DE ORCAMENTO e STATUS ORCAMENTO
        private void ValidacaoValoresSetPropriedades(string cep, string logradouro, string numero, string bairro, string cidade, string referencia
            ,string contato1,string contato2, string email,DateTime dataEvento,DateTime horarioInicio,DateTime horarioTermino, string tipoEvento
            ,Decimal valorFrete,Decimal valorTotalServ,Decimal valorTotalProd, DateTime dataValidadeOrc, string statusOrc)
        {
            DomainException.Quando(string.IsNullOrEmpty(cep), "Cep é Obrigatório");
            DomainException.Quando(cep.Length < 8, "Cep Invalido");
            DomainException.Quando(string.IsNullOrEmpty(logradouro), "Logradouro é Obrigatório");
            DomainException.Quando(string.IsNullOrEmpty(numero), "Numero é Obrigatório");
            DomainException.Quando(numero.Length < 0, "Numero Invalido");
            DomainException.Quando(string.IsNullOrEmpty(bairro), "Bairro é Obrigatório");
            DomainException.Quando(bairro.Length < 0, "Numero Invalido");
            DomainException.Quando(string.IsNullOrEmpty(cidade), "Cidade é Obrigatório");
            DomainException.Quando(cidade.Length < 0, "Numero Invalido");
            DomainException.Quando(string.IsNullOrEmpty(contato1), "Contatoé Obrigatório");
            DomainException.Quando(contato1.Length < 11 , "Contato Invalido");
            DomainException.Quando(string.IsNullOrEmpty(contato2), "Contato é Obrigatório");
            DomainException.Quando(contato2.Length < 11, "Contato Invalido");
            DomainException.Quando(string.IsNullOrEmpty(email), "Email é Obrigatório");
            DomainException.Quando(valorFrete < 0, "Valor Frete Invalido");
            DomainException.Quando(valorTotalProd < 0, "Valor Frete Invalido");
            DomainException.Quando(valorTotalServ < 0, "Valor Frete Invalido");

            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Referencia = referencia;
            Contato1 = contato1;
            Contato2 = contato2;
            Email = email;
            DataEvento = dataEvento;
            HorarioInicio = horarioInicio;
            HorarioTermino = horarioTermino;
            TipoEvento = tipoEvento;
            ValorFrete = valorFrete;
            ValorTotalServ = valorTotalServ;
            ValorTotalProd = valorTotalProd;
            DataValidadeOrc = dataValidadeOrc;
            StatusOrc = statusOrc;
           
        }

        public void Update(string cep, string logradouro, string numero, string bairro, string cidade, string referencia
            , string contato1, string contato2, string email, DateTime dataEvento, DateTime horarioInicio, DateTime horarioTermino, string tipoEvento
            , Decimal valorFrete, Decimal valorTotalServ, Decimal valorTotalProd, DateTime dataValidadeOrc, string statusOrc)
        {
            ValidacaoValoresSetPropriedades( cep,  logradouro, numero, bairro,  cidade, referencia
            , contato1,  contato2, email,  dataEvento, horarioInicio, horarioTermino,  tipoEvento
            ,  valorFrete,  valorTotalServ,  valorTotalProd, dataValidadeOrc, statusOrc);
        }

    }
}
