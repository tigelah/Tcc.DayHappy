using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Orcamentos;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Dominio.Armazenar
{
    public class OrcamentoArmazenar
    {
        private readonly IRepository<Orcamento> _orcamentoRepository;
        private readonly IRepository<PessoaFisica> _pessoaFisicaRepository;
        private readonly IRepository<PessoaJuridica> _pessoaJuridicaRepository;

        public OrcamentoArmazenar(IRepository<Orcamento> orcamentoRepository,
            IRepository<PessoaFisica> pessoaFisicaRepository,
            IRepository<PessoaJuridica> pessoaJuridicaRepository)
        {
            _orcamentoRepository = orcamentoRepository;
            _pessoaFisicaRepository = pessoaFisicaRepository;
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }
        public void  Armazenar(int id,string cep, string logradouro, string numero, string bairro, string cidade, string referencia
            , string contato1, string contato2, string email, DateTime dataEvento, DateTime horarioInicio, DateTime horarioTermino, string tipoEvento
            , Decimal valorFrete, Decimal valorTotalServ, Decimal valorTotalProd, DateTime dataValidadeOrc, string statusOrc,PessoaFisica pessoaFisica, PessoaJuridica pessoaJuridica)
        {
             

            var orcamento = _orcamentoRepository.GetById(id);

            if(orcamento == null)
            {
                orcamento = new Orcamento(cep, logradouro, numero, bairro, cidade, referencia, contato1, contato2, email, 
                    dataEvento, horarioInicio, horarioTermino, tipoEvento, valorFrete, valorTotalServ, valorTotalProd, dataValidadeOrc, statusOrc,pessoaFisica, pessoaJuridica);
                _orcamentoRepository.Save(orcamento);

            }
            else
            {
                orcamento.Update(cep, logradouro, numero, bairro, cidade, referencia, contato1, contato2, email,
                    dataEvento, horarioInicio, horarioTermino, tipoEvento, valorFrete, valorTotalServ, valorTotalProd, dataValidadeOrc, statusOrc, pessoaFisica,pessoaJuridica);
            }
        }

    }
}
