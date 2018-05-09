using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.FormaPagamento;
using Tcc.DayHappy.Dominio.Orcamentos;

namespace Tcc.DayHappy.Dominio.Armazenar
{
    class PagamentoArmazenar
    {
        private readonly IRepository<Pagamento> _pagamentoRepository;

        public PagamentoArmazenar(IRepository<Pagamento> pagamentoRepository)
        {
             _pagamentoRepository = pagamentoRepository;
        }

        public void Armazenar(int id,Orcamento codOrcamento,string statusPagamento,DateTime dataConfirmacaoPagamento
            ,decimal valorEntrada,decimal valorRestante,DateTime validadeConfirmacaoPagamento)
        {
            var pagamentos = _pagamentoRepository.GetById(id);
            if(pagamentos == null)
            {
                pagamentos = new Pagamento(codOrcamento, statusPagamento, dataConfirmacaoPagamento, valorEntrada, valorRestante, validadeConfirmacaoPagamento);
                _pagamentoRepository.Save(pagamentos);
            }
            else
            {
                pagamentos.Update(codOrcamento, statusPagamento, dataConfirmacaoPagamento, valorEntrada, valorRestante, validadeConfirmacaoPagamento);
            }

                

        }



    }
}
