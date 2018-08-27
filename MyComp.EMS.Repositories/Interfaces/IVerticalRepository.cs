using System.Collections.Generic;
using MyComp.EMS.Repositories.Models;
using MyComp.EMS.Data.Interfaces;


namespace MyComp.EMS.Repositories.Interfaces
{
    public interface IVerticalRepository
    {
        IEnumerable<Vertical> GetVerticals();
        void AddVertical(Vertical entity);
        void RemoveVertical(Vertical entity);
        Vertical GetVerticalByID(int Id);
    }
}
