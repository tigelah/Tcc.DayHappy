using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Web.Models
{
    public class ClientePJViewModel
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get;  set; }
        public string Bairro { get; set; }
        public string Cidade { get;  set; }
        public int Contato1 { get; set; }
        public int Contato2 { get; set; }
        public string Email { get; set; }
        public string Referencia { get; set; }
        public string Complemento { get; set; }
        public string RAZAO_SOCIAL { get; set; }
        public string NOME_REPRESENTANTE { get;  set; }
        public string NOME_FANTASIA { get; set; }
        public string CNPJ { get;  set; }
        public string INSCRICAO_ESTADUAL { get;set; }

    }
}
