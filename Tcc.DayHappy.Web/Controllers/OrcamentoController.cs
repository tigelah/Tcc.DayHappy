using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Armazenar;
using Tcc.DayHappy.Dominio.Orcamentos;
using Tcc.DayHappy.Dominio.Storer;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Web.Controllers
{
    public class OrcamentoController : Controller
    {


        private readonly OrcamentoArmazenar _orcamentoArmazenar;
        private readonly IRepository<Orcamento> _orcamentoRepository;
        private readonly IRepository<PessoaJuridica> _PessoaPJRepository;
        private readonly IRepository<PessoaFisica> _pessoaPFRepository;

        public OrcamentoController(OrcamentoArmazenar orcamentoArmazenar, 
            IRepository<Orcamento> orcamentoRepository, 
            IRepository<PessoaJuridica> pessoaPJRepository,
            IRepository<PessoaFisica> pessoaPFRepository)
        {
            _orcamentoArmazenar = orcamentoArmazenar;
            _orcamentoRepository = orcamentoRepository;
            _pessoaPFRepository = pessoaPFRepository;
            _PessoaPJRepository = pessoaPJRepository;
        }

        public IActionResult Index()
        {
            return View();
        }





    }
}