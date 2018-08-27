using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyComp.EMS.Data.Interfaces
{
    public interface IUnitOfWork {
        IGenericRepo<T> Repository<T>() where T : class;
        void SaveChanges();
    }
}
