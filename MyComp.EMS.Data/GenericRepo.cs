using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyComp.EMS.Data.Interfaces;

namespace MyComp.EMS.Data
{
    public class GenericRepo<T> : IGenericRepo<T>
        where T : class
    {
        private readonly EMSDBContext eMSDBContext;
        private readonly IDbSet<T> entities;

        public GenericRepo(EMSDBContext emsDBContext)
        {
            this.eMSDBContext = emsDBContext;
            this.entities = eMSDBContext.Set<T>();
        }
        public void Add(T entity)
        {
            entities.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetSingle(Expression<Func<T,bool>> expression)
        {
            return entities.FirstOrDefault(expression);
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
        }
    }
}
