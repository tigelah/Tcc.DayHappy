using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Web.Models
{
    public class OrcamentoViewModel 
    {
        public virtual PessoaFisica PesssoaFisica { get; private set; }
        public virtual PessoaJuridica PessoaJuridica { get; private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Referencia { get; private set; }
        public string Contato1 { get; private set; }
        public string Contato2 { get; private set; }
        public string Email { get; private set; }
        public DateTime DataEvento { get; private set; }
        public DateTime HorarioInicio { get; private set; }
        public DateTime HorarioTermino { get; private set; }
        public string TipoEvento { get; private set; }
        public decimal ValorFrete { get; private set; }
        public decimal ValorTotalServ { get; private set; }
        public decimal ValorTotalProd { get; private set; }
        public DateTime DataValidadeOrc { get; private set; }
        public string StatusOrc { get; private set; }



    }
}
