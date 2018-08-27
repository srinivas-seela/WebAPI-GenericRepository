using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyComp.EMS.Data.Interfaces;

namespace MyComp.EMS.Data
{
    public class UnitOfWork : IUnitOfWork        
    {
        private readonly EMSDBContext eMSDBContext;
        private Dictionary<Type, object> Repositories = new Dictionary<Type, object>();
        public UnitOfWork(EMSDBContext emsDBContext)
        {
            this.eMSDBContext = emsDBContext;           
        }
        public IGenericRepo<T> Repository<T>() where T : class
        {
            if (Repositories.Keys.Contains(typeof(T)) == true)
            {
                return Repositories[typeof(T)] as IGenericRepo<T>;
            }
            IGenericRepo<T> repo = new GenericRepo<T>(eMSDBContext);
            Repositories.Add(typeof(T), repo);
            return repo;
        }
        public void SaveChanges()
        {
            eMSDBContext.SaveChanges();
        }
        
    }
}
