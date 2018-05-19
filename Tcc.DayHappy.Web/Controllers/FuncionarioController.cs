using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Storer;
using Tcc.DayHappy.Dominio.Usuario;
using Tcc.DayHappy.Web.Models;

namespace Tcc.DayHappy.Web.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly FuncionarioArmazenar _funcionarioArmazenar;
        private readonly IRepository<Funcionario> _funcionarioRepository;

        public FuncionarioController(FuncionarioArmazenar funcionarioArmazenar, IRepository<Funcionario> funcionarioRepository)
        {
            _funcionarioArmazenar = funcionarioArmazenar;
            _funcionarioRepository = funcionarioRepository;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CadastrarFuncionario(int id)
        {
            var viewModel = new FuncionarioViewModelcs();

            if (id > 0)
            {
                var pessoafisica = _funcionarioRepository.GetById(id);
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
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarFuncionario(FuncionarioViewModelcs viewModel)
        {
            _funcionarioArmazenar.Armazenar(0, viewModel.Nome, viewModel.DataNasc, viewModel.Sexo,
               viewModel.Cpf, viewModel.Rg, viewModel.NomeCargo,viewModel.Salario,viewModel.DataAdm, viewModel.Contato1, viewModel.Cep, viewModel.Logradouro, viewModel.Numero, viewModel.Bairro, viewModel.Cidade
               , viewModel.Contato2, viewModel.Email,viewModel.Referencia);
            return RedirectToAction("CadastrarCliente");

        }


    }
}