using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Dominio.ContaUsuarios
{
    public interface IManager
    {
        Task<bool> CreateAsync(string email, string password, string role);
        List<IUser> ListAll();
    }
}
