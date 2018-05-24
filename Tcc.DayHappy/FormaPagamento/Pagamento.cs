using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Orcamentos;

namespace Tcc.DayHappy.Dominio.FormaPagamento
{
    public class Pagamento : Entity
    {
        public Orcamento CodOrcamento { get; private set; }
        public string StatusPagamento { get; private set; } // Confirmar se esse campo não vai ser boleano
        public DateTime DataConfirmacaoPagamento { get; private set; }
        public decimal ValorEntrada { get; private set; }
        public decimal ValorRestante { get; private set; }
        public DateTime ValidadeConfirmacaoPagamento { get; private set; }

        protected Pagamento() { }

        //Lembrar dos tratamentos das DATAS 
        public Pagamento(Orcamento codOrcamento, string statusPagamento, DateTime dataConfirmacaoPag,decimal valorEntrada,decimal valorRestante,DateTime validadeConfimacaoPag)
        {
            ValidacaoValoresSetPropriedades(codOrcamento, statusPagamento, dataConfirmacaoPag, valorEntrada, valorRestante, validadeConfimacaoPag);
        }

        private void ValidacaoValoresSetPropriedades(Orcamento codOrcamento, string statusPagamento, DateTime dataConfirmacaoPag, decimal valorEntrada, decimal valorRestante, DateTime validadeConfimacaoPag)
        {
            DomainException.Quando(codOrcamento == null, "Orçamento não foi completado corretamente");
            DomainException.Quando(string.IsNullOrEmpty(statusPagamento), "Status Digitado Invalido");
            DomainException.Quando(statusPagamento.Length <= 1, "Status Invalido");
            DomainException.Quando(valorEntrada <= 0, "Valor Entrada Invalido");

            CodOrcamento = codOrcamento;
            StatusPagamento = statusPagamento;
            DataConfirmacaoPagamento = dataConfirmacaoPag;
            ValorEntrada = valorEntrada;
            ValorRestante = valorRestante;
            ValidadeConfirmacaoPagamento = validadeConfimacaoPag;
        }

        public void Update(Orcamento codOrcamento, string statusPagamento, DateTime dataConfirmacaoPag, decimal valorEntrada, decimal valorRestante, DateTime validadeConfimacaoPag)
        {
            ValidacaoValoresSetPropriedades(codOrcamento, statusPagamento, dataConfirmacaoPag, valorEntrada, valorRestante, validadeConfimacaoPag);
        }
    }
}
