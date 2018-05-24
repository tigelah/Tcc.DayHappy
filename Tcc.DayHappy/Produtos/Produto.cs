using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Produtos
{
    public class Produto : Entity
    {
        public string  NomeProduto { get;  private set; }
        public decimal ValorLocacao { get; private set; }
        public decimal ValorCusto { get; private set; }
        public string FaixaEtaria { get; private set; }
        public DateTime DataCompra { get; private set; }
        public string Descricao { get; private set; }
        public string CheckListPecas { get; private set; }

        protected Produto() { }

        public Produto(string nomeProduto, string faixaEtaria, string descricao, DateTime dataCompra,
            decimal valorLocacao, decimal valorCusto, string checkListPecas)
        {
            ValidacaoValoresSetPropriedades(nomeProduto, faixaEtaria, descricao, dataCompra, valorLocacao, valorCusto, checkListPecas);
        }

        //Lembrar de rever todos os tratamentos--> data compra
        //(ATENÇÃO) com check list de pecas é obrigatorio ???
        private  void ValidacaoValoresSetPropriedades(string nomeProduto, string faixaEtaria, string descricao, DateTime dataCompra,
            decimal valorLocacao, decimal valorCusto, string checkListPecas)
        {
            DomainException.Quando(string.IsNullOrEmpty(nomeProduto), "Nome do Produto é obrigatorio");
            DomainException.Quando(nomeProduto.Length < 1, "Nome do produto Invalido");
            DomainException.Quando(string.IsNullOrEmpty(faixaEtaria), "Faixa Etaria é obrigatoria");
            DomainException.Quando(faixaEtaria.Length < 1, "Faixa Etaria Invalida");
            DomainException.Quando(valorLocacao < 0, "Valor Locação Invalido");
            DomainException.Quando(valorCusto < 0, "Valor Locação Invalido");
            DomainException.Quando(checkListPecas.Length < 0, "Check List das Peças Invalido");
            // DomainException.Quando(string.IsNullOrEmpty(checkListPecas),"Check List das Pecas é Obrigatorio")
            NomeProduto = nomeProduto;
            FaixaEtaria = faixaEtaria;
            Descricao = descricao;
            DataCompra = dataCompra;
            ValorLocacao = valorLocacao;
            ValorCusto = valorCusto;
            CheckListPecas = checkListPecas;

        }

        public void Update(string nomeProduto, string faixaEtaria, string descricao, DateTime dataCompra,
            decimal valorLocacao, decimal valorCusto, string checkListPecas)
        {
            ValidacaoValoresSetPropriedades(nomeProduto, faixaEtaria, descricao, dataCompra, valorLocacao, valorCusto, checkListPecas);
        }
    }
}
