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
    public class ClientePJController : Controller
    {
        private readonly PessoaJuridicaArmazenar _pessoaJuridicaArmazenar;
        private readonly IRepository<PessoaJuridica> _pessoaJuridicaRepository;

        public ClientePJController(PessoaJuridicaArmazenar pessoaJuridicaArmazenar, IRepository<PessoaJuridica> pessoaJuridicaRepository)
        {
            _pessoaJuridicaArmazenar = pessoaJuridicaArmazenar;
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }
        public IActionResult CadastrarClientePJ(int id)
        {
            var viewModel = new ClientePJViewModel();

            if (id > 0)
            {
                var PessoaJuridca = _pessoaJuridicaRepository.GetById(id);
                viewModel.Id = PessoaJuridca.Id;
                viewModel.NomeEmpresa = PessoaJuridca.NomeEmpresa;
                viewModel.Representante= PessoaJuridca.Representante;
                viewModel.Bairro = PessoaJuridca.Bairro;
                viewModel.Cep = PessoaJuridca.Cep;
                viewModel.Cidade = PessoaJuridca.Cidade;
                viewModel.Cnpj = PessoaJuridca.Cnpj;
                viewModel.InscEstadual= PessoaJuridca.InscEstadual;
                viewModel.Contato1 = PessoaJuridca.Contato1;
                viewModel.Logradouro = PessoaJuridca.Logradouro;
                viewModel.Numero = PessoaJuridca.Numero;
                viewModel.Contato2 = PessoaJuridca.Contato2;
                viewModel.Email = PessoaJuridca.Email;

                return View(viewModel);
            }
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarClientePJ(ClientePJViewModel viewModel)
        {
            _pessoaJuridicaArmazenar.Armazenar(viewModel.Id, viewModel.Representante, viewModel.NomeEmpresa, viewModel.Cnpj,
               viewModel.InscEstadual, viewModel.Contato1,viewModel.Cep, viewModel.Logradouro, viewModel.Numero, viewModel.Bairro, viewModel.Cidade
               , viewModel.Contato2, viewModel.Email);
            return RedirectToAction("CadastrarCliente");

        }

    /*    [HttpPost]
        public IActionResult DeletarCliente(ClientePFViewModel viewModel)
        {
            _pessoaJuridicaArmazenar.Deletar(viewModel.Id, viewModel.Representante, viewModel.NomeEmpresa, viewModel.Cnpj,
               viewModel.InscEstadual, viewModel.Contato1, viewModel.Cep, viewModel.Logradouro, viewModel.Numero, viewModel.Bairro, viewModel.Cidade
               , viewModel.Contato2, viewModel.Email); ;
            return RedirectToAction("CadastrarCliente");

        }
        */

    }
}


    
