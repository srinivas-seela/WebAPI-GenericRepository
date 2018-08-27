using System;

namespace MyComp.EMS.Data.Interfaces
{
    public interface BaseEntity
    {
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime LastedUpdatedDate { get; set; }
        string LastUpdatedBy { get; set; }
        bool ActiveStatus { get; set; }
    }
}
