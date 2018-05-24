using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tcc.DayHappy.Data.Repositorios;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Armazenar;
using Tcc.DayHappy.Dominio.Storer;
using Tcc.DayHappy.Dominio.Usuario;
using Tcc.DayHappy.Web.Models;

namespace Tcc.DayHappy.Web.Controllers
{
    public class ClientePJController : Controller
    {
        private readonly PessoaJuridicaArmazenar _pessoaJuridicaArmazenar;
        private readonly PessoaJuridicaRepository _pessoaJuridicaRepository;
       private readonly ContatoArmazenar _contatoArmazenar;

        public ClientePJController(PessoaJuridicaArmazenar pessoaJuridicaArmazenar, PessoaJuridicaRepository pessoaJuridicaRepository,
            ContatoArmazenar contatoArmazenar)
        {
            _pessoaJuridicaArmazenar = pessoaJuridicaArmazenar;
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
            _contatoArmazenar = contatoArmazenar;
        }

    
        public IActionResult CadastrarClientePJ(int id)
        {
            var viewModel = new ClientePJViewModel();

            if (id > 0)
            {
                var PessoaJuridca = _pessoaJuridicaRepository.GetById(id);
                viewModel.Id = PessoaJuridca.Id;
                viewModel.NOME_FANTASIA = PessoaJuridca.NOME_FANTASIA;
                viewModel.NOME_REPRESENTANTE = PessoaJuridca.NOME_REPRESENTANTE;
                viewModel.RAZAO_SOCIAL = PessoaJuridca.RAZAO_SOCIAL;
                viewModel.CNPJ = PessoaJuridca.CNPJ;
                viewModel.INSCRICAO_ESTADUAL= PessoaJuridca.INSCRICAO_ESTADUAL;
               

                return View(viewModel);
            }
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarClientePJ(ClientePJViewModel viewModel)
        {
            _pessoaJuridicaArmazenar.Armazenar(viewModel.Id, viewModel.RAZAO_SOCIAL, viewModel.NOME_REPRESENTANTE, viewModel.NOME_FANTASIA,
               viewModel.CNPJ, viewModel.INSCRICAO_ESTADUAL);
           var fk = _pessoaJuridicaRepository.Pesquisa();

            _contatoArmazenar.ArmazenarPJ(viewModel.Complemento, viewModel.Referencia, viewModel.Contato1, viewModel.Contato2, viewModel.Cep, viewModel.Logradouro, viewModel.Numero, viewModel.Bairro, viewModel.Cidade
               , viewModel.Email, fk.Id);


            return RedirectToAction("CadastrarClientePJ");

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


    
