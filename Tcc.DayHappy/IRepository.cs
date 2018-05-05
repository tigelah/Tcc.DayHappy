using System;
using System.Collections.Generic;
using System.Text;

namespace Tcc.DayHappy.Dominio
{
    public interface IRepository<TEntity>
    {
        TEntity GetByID(int id);
        IEnumerable<TEntity> All();
        void Save(TEntity entity);

    }
}
