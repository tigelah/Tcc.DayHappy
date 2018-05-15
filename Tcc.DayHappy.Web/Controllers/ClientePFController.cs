using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Controllers
{
    public class ClientePFController : Controller
    {
        public IActionResult Cliente()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contato(string cep,string logradouro,string numero,string bairro,string cidade,int contato1,int contato2,
            string email)
        {


            return View();
        }


    }
}
