using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Orcamentos;
using Tcc.DayHappy.Dominio.Produtos;

namespace Tcc.DayHappy.Dominio.OrcamentoProduto

{
   public class OrcamentoProduto : Entity
    {
        public virtual Orcamento Orcamento { get; private set; }
        public virtual Produto Produto { get; private set; }


        protected OrcamentoProduto() { }


        public OrcamentoProduto(Orcamento orcamento, Produto produto)
        {
            ValidacaoValores(orcamento, produto);
        }

        private static void ValidacaoValores(Orcamento orcamento, Produto produto)
        {
            DomainException.Quando(orcamento == null, "Orçamento não foi completado corretamente");
            DomainException.Quando(produto == null, "Produto não foi completado corretamente");
        }

        public void Update(Orcamento orcamento,Produto produto)
        {
            ValidacaoValores(orcamento, produto);
        }


    }
}
