using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.Produtos;

namespace Tcc.DayHappy.Dominio.Armazenar
{
    public class ProdutoArmazenar
    {
        private readonly IRepository<Produto> _produtoRepository;

        public ProdutoArmazenar(IRepository<Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    

        public void Armazenar(int id , string nomeProduto, string faixaEtaria, string descricao, DateTime dataCompra,
            decimal valorLocacao, decimal valorCusto, string checkListPecas)
        {
            var produto = _produtoRepository.GetById(id);

            if(produto == null)
            {
                produto = new Produto(nomeProduto, faixaEtaria, descricao, dataCompra, valorLocacao, valorCusto, checkListPecas);
                _produtoRepository.Save(produto);
            }
            else
            {
                produto.Update(nomeProduto, faixaEtaria, descricao, dataCompra, valorLocacao, valorCusto, checkListPecas);
            }
        }

        public void Deletar(int id, string nomeProduto, string faixaEtaria, string descricao, DateTime dataCompra,
            decimal valorLocacao, decimal valorCusto, string checkListPecas)
        {
            var produto = _produtoRepository.GetById(id);

            if (produto != null)
            {
                _produtoRepository.Delete(produto);
            }
            else
            {
                produto.Update(nomeProduto, faixaEtaria, descricao, dataCompra, valorLocacao, valorCusto, checkListPecas);
            }



        }
    }
}
