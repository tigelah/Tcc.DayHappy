using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Storer;
using Tcc.DayHappy.Dominio.Usuario;
using Tcc.DayHappy.Web.Models;

namespace Tcc.DayHappy.Web.Controllers
{
    public class ClientePFController : Controller
    {
        private readonly PessoaFisicaArmazenar _pessoaFisicaArmazenar;
        private readonly IRepository<PessoaFisica> _pessoaFisicaRepository;

        public ClientePFController(PessoaFisicaArmazenar pessoaFisicaArmazenar,IRepository<PessoaFisica> pessoaFisicaRepository)
        {
            _pessoaFisicaArmazenar = pessoaFisicaArmazenar;
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
        public IActionResult Index()
        {
            var pessoafisica = _pessoaFisicaRepository.All();
            if (pessoafisica.Any())
            {
                var viewmodel = pessoafisica.Select(p => new ClientePFViewModel
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    DataNasc = p.DataNasc,
                    Sexo = p.Sexo,
                    Cpf = p.Cpf,
                    Rg = p.Rg,
                    Logradouro = p.Logradouro,
                    Numero = p.Numero,
                    Bairro = p.Bairro,
                    Cidade = p.Cidade,
                    Contato1 = p.Contato1,
                    Contato2 = p.Contato2,
                    Email = p.Email,
                    Referencia = p.Referencia
                });
                return View(viewmodel);
            }
            return View();
        }
        public IActionResult CadastrarCliente(int id)
        {
            var viewModel = new ClientePFViewModel();

            if (id > 0)
            {
                var pessoafisica = _pessoaFisicaRepository.GetById(id);
                viewModel.Id = pessoafisica.Id;
                viewModel.Nome = pessoafisica.Nome;
                viewModel.DataNasc = pessoafisica.DataNasc;
                viewModel.Sexo = pessoafisica.Sexo;
                viewModel.Cpf = pessoafisica.Cpf;
                viewModel.Rg = pessoafisica.Rg;
                viewModel.Referencia = pessoafisica.Referencia;
                viewModel.Contato1 = pessoafisica.Contato1;
                viewModel.Cep = pessoafisica.Cep;
                viewModel.Logradouro = pessoafisica.Logradouro;
                viewModel.Numero = pessoafisica.Numero;
                viewModel.Bairro = pessoafisica.Bairro;
                viewModel.Cidade = pessoafisica.Cidade;
                viewModel.Contato2 = pessoafisica.Contato2;
                viewModel.Email = pessoafisica.Email;
               
                return View(viewModel);
            }
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult CadastrarCliente(ClientePFViewModel viewModel)
        {
            _pessoaFisicaArmazenar.Armazenar(viewModel.Id, viewModel.Nome, viewModel.DataNasc, viewModel.Sexo,
               viewModel.Cpf, viewModel.Rg, viewModel.Referencia, viewModel.Contato1, viewModel.Cep, viewModel.Logradouro, viewModel.Numero, viewModel.Bairro, viewModel.Cidade
               , viewModel.Contato2, viewModel.Email);
            return RedirectToAction("CadastrarCliente");

        }

        [HttpPost]
        public IActionResult DeletarCliente(ClientePFViewModel viewModel)
        {
            _pessoaFisicaArmazenar.Deletar(viewModel.Id, viewModel.Nome, viewModel.DataNasc, viewModel.Sexo,
               viewModel.Cpf, viewModel.Rg, viewModel.Referencia, viewModel.Contato1, viewModel.Cep, viewModel.Logradouro, viewModel.Numero, viewModel.Bairro, viewModel.Cidade
               , viewModel.Contato2, viewModel.Email);
            return RedirectToAction("CadastrarCliente");

        }

    }
}
