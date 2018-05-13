using System;

namespace Tcc.DayHappy.Dominio.Usuario
{
    public class Pessoa : Entity

    {
        public string Nome { get; private set;}
        public DateTime DataNasc { get; private set; }
        public string Sexo { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        

    }
}
