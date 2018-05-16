using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Models
{
    public class FuncionarioViewModelcs
    {
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Contato1 { get; set; }
        public int Contato2 { get; set; }
        public string Email { get; set; }
        public string NomeCargo { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdm { get; set; }
        public string Referencia { get; set; }
    }
}
