using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Tcc.DayHappy.Dominio.ContaUsuarios;

namespace Tcc.DayHappy.Data.Identity
{
    public class ApplicationUser : IdentityUser , IUser
    {
    }
}
