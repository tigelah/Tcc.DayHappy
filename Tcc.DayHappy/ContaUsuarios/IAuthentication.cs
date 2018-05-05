using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Dominio.ContaUsuarios
{
    public interface IAuthentication
    {
        Task<bool> Authenticate(string email, string password);
        Task Logout();
    }
}

