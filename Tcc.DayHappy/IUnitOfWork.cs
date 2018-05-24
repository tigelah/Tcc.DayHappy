using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tcc.DayHappy.Dominio
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
