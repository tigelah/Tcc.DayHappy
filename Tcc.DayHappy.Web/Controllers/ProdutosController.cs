using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Armazenar;
using Tcc.DayHappy.Dominio.Produtos;
using Tcc.DayHappy.Web.Models;

namespace Tcc.DayHappy.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IRepository<Produto> _produtoRepository;
        private readonly ProdutoArmazenar _produtoArmazenar;
    
       public ProdutosController(ProdutoArmazenar produtoArmazenar,IRepository<Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _produtoArmazenar = produtoArmazenar;

        }
        public IActionResult ListadeProdutos()

        {
            var produto = _produtoRepository.All();
            if(produto.Any())
            {
                var viewmodel = produto.Select(p => new ProdutoViewModel
                {
                    Id = p.Id,
                    NomeProduto = p.NomeProduto,
                    FaixaEtaria = p.FaixaEtaria,
                    Descricao = p.Descricao,
                    DataCompra = p.DataCompra,
                    ValorLocacao = p.ValorLocacao,
                    ValorCusto = p.ValorCusto,
                    CheckListPecas = p.CheckListPecas });
                return View(viewmodel);
            }
            return View();
        }
        public IActionResult CadastrarOuEditar(int id)
        {
            var viewModel = new ProdutoViewModel();

            if (id > 0)
            {
                var produto = _produtoRepository.GetById(id);
                viewModel.Id = produto.Id;
                viewModel.NomeProduto = produto.NomeProduto;
                viewModel.FaixaEtaria = produto.FaixaEtaria;
                viewModel.Descricao = produto.Descricao;
                viewModel.DataCompra = produto.DataCompra;
                viewModel.ValorLocacao = produto.ValorLocacao;
                viewModel.ValorCusto = produto.ValorCusto;
                viewModel.CheckListPecas = produto.CheckListPecas;
                return View(viewModel);
            }
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult CadastrarOuEditar(ProdutoViewModel viewModel)
        {
            _produtoArmazenar.Armazenar(viewModel.Id, viewModel.NomeProduto, viewModel.FaixaEtaria, viewModel.Descricao,
                viewModel.DataCompra, viewModel.ValorLocacao, viewModel.ValorCusto, viewModel.CheckListPecas);
            return RedirectToAction("ListadeProdutos");
        }


        public IActionResult DeletarProdutos(int id)
        {
            var produto = _produtoRepository.All();
            if (produto.Any())
            {
                var viewmodel = produto.Select(p => new ProdutoViewModel
                {
                    Id = p.Id,
                    NomeProduto = p.NomeProduto,
                    FaixaEtaria = p.FaixaEtaria,
                    Descricao = p.Descricao,
                    DataCompra = p.DataCompra,
                    ValorLocacao = p.ValorLocacao,
                    ValorCusto = p.ValorCusto,
                    CheckListPecas = p.CheckListPecas
                });
                return View(viewmodel);
            }
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarProdutos(ProdutoViewModel viewModel)
        {

            _produtoArmazenar.Deletar(viewModel.Id, viewModel.NomeProduto, viewModel.FaixaEtaria, viewModel.Descricao,
                            viewModel.DataCompra, viewModel.ValorLocacao, viewModel.ValorCusto, viewModel.CheckListPecas);
            return RedirectToAction("ListadeProdutos");

        }
    }
}