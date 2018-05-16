using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Models
{
    public class ClientePJViewModel
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get;  set; }
        public string Bairro { get; set; }
        public string Cidade { get;  set; }
        public int Contato1 { get; set; }
        public int Contato2 { get; set; }
        public string Email { get; set; }
        public string Representante { get;  set; }
        public string NomeEmpresa { get; set; }
        public string Cnpj { get;  set; }
        public string InscEstadual { get; set; }
    }
}
