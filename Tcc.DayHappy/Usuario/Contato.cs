using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio.Usuario
{
    public class  Contato : Entity
    {
       public string Cep { get; private set; }
       public string Logradouro { get; private set; }
       public string Numero { get; private set; }
       public string Bairro { get; private set; }
       public string Cidade { get; private set; }
       public int Contato1 { get; private set; }
       public int Contato2 { get; private set; }
       public string Email { get; private set; }

    }
}
