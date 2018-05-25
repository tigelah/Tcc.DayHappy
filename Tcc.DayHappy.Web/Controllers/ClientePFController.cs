using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Armazenar;
using Tcc.DayHappy.Dominio.Storer;
using Tcc.DayHappy.Dominio.Usuario;
using Tcc.DayHappy.Web.Models;
using Tcc.DayHappy.Data.Repositorios;

namespace Tcc.DayHappy.Web.Controllers
{
    public class ClientePFController : Controller
    {
        private readonly PessoaFisicaArmazenar _pessoaFisicaArmazenar;
        private readonly ContatoArmazenar _contatoArmazenar;
        private readonly PessoaFisicaRepository _pessoaFisicaRepository;

        public ClientePFController(PessoaFisicaArmazenar pessoaFisicaArmazenar,PessoaFisicaRepository pessoaFisicaRepository,
            ContatoArmazenar contatoArmazenar)
        {
            _pessoaFisicaArmazenar = pessoaFisicaArmazenar;
            _pessoaFisicaRepository = pessoaFisicaRepository;
            _contatoArmazenar = contatoArmazenar;
        }


        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;
            var pessoafisica = from s in _pessoaFisicaRepository.GetAll()
                               select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                pessoafisica = pessoafisica.Where(s => s.NOME_PES_FIS.Contains(searchString)
                                       || s.CPF_PES_FIS.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    pessoafisica = pessoafisica.OrderByDescending(s => s.NOME_PES_FIS);
                    break;
                case "Date":
                    pessoafisica = pessoafisica.OrderBy(s => s.NASC_PES_FIS);
                    break;
                case "date_desc":
                    pessoafisica = pessoafisica.OrderByDescending(s => s.NASC_PES_FIS);
                    break;
                default:
                    pessoafisica = pessoafisica.OrderBy(s => s.NOME_PES_FIS);
                    break;
            }
            if (pessoafisica.Any())
              {
                  var viewmodel = pessoafisica.Select(p => new ClientePFViewModel
                  {
                      Id = p.Id,
                      Nome = p.NOME_PES_FIS,
                      DataNasc = p.NASC_PES_FIS,
                      Sexo = p.SEXO_PES_FIS,
                      Cpf = p.CPF_PES_FIS,
                      Rg = p.RG_PES_FIS,

                  });
                  return View(viewmodel);
              }
              return View();
          }
         
     
     /*   public async Task<IActionResult> Index(string sortOrder,string searchString)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;
            var pessoafisica = from s in _pessoaFisicaRepository.GetAll()
                               select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                pessoafisica = pessoafisica.Where(s => s.NOME_PES_FIS.Contains(searchString)
                                       || s.CPF_PES_FIS.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    pessoafisica = pessoafisica.OrderByDescending(s => s.NOME_PES_FIS);
                    break;
                case "Date":
                    pessoafisica = pessoafisica.OrderBy(s => s.NASC_PES_FIS);
                    break;
                case "date_desc":
                    pessoafisica = pessoafisica.OrderByDescending(s => s.NASC_PES_FIS);
                    break;
                default:
                    pessoafisica = pessoafisica.OrderBy(s => s.NOME_PES_FIS);
                    break;
            }
            return View();
        }*/
        
        public IActionResult CadastrarCliente(int id)
        {
            var viewModel = new ClientePFViewModel();

            if (id > 0)
            {
                var pessoafisica = _pessoaFisicaRepository.GetById(id);
                viewModel.Id = pessoafisica.Id;
                viewModel.Nome = pessoafisica.NOME_PES_FIS;
                viewModel.DataNasc = pessoafisica.NASC_PES_FIS;
                viewModel.Sexo = pessoafisica.SEXO_PES_FIS;
                viewModel.Cpf = pessoafisica.CPF_PES_FIS;
                viewModel.Rg = pessoafisica.RG_PES_FIS;
               
        
               
                return View(viewModel);
            }
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarCliente(ClientePFViewModel viewModel)
        {
            _pessoaFisicaArmazenar.Armazenar(viewModel.Id, viewModel.Nome, viewModel.DataNasc, viewModel.Sexo,
               viewModel.Cpf, viewModel.Rg);
              var fk =_pessoaFisicaRepository.Pesquisa();
            _contatoArmazenar.ArmazenarPF(viewModel.Complemento,viewModel.Referencia, viewModel.Contato1, viewModel.Cep, viewModel.Logradouro, viewModel.Numero, viewModel.Bairro, viewModel.Cidade
               , viewModel.Contato2, viewModel.Email, fk.Id);

            return RedirectToAction("CadastrarCliente");

        }


        public IActionResult DeletarCliente(ClientePFViewModel viewModel)
        {
             viewModel = new ClientePFViewModel();

            if (viewModel.Id > 0)
            {
                var pessoafisica = _pessoaFisicaRepository.GetById(viewModel.Id);
                viewModel.Id = pessoafisica.Id;
                viewModel.Nome = pessoafisica.NOME_PES_FIS;
                viewModel.DataNasc = pessoafisica.NASC_PES_FIS;
                viewModel.Sexo = pessoafisica.SEXO_PES_FIS;
                viewModel.Cpf = pessoafisica.CPF_PES_FIS;
                viewModel.Rg = pessoafisica.RG_PES_FIS;



                return View(viewModel);
            }
            return View();
        }

        [HttpPost]
        public IActionResult DeletarCliente(int id)
        {
            _pessoaFisicaArmazenar.Deletar(id);


            return RedirectToAction("Index");

        }

    }
}
