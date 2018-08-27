using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace MyComp.EMS.Data.Interfaces
{
    public interface IGenericRepo<T> where T: class
    {
        void Add(T Entity);
        void Remove(T Entity);
        IEnumerable<T> GetAll();
        T GetSingle(Expression<Func<T,bool>> myExpression);
    }
}
