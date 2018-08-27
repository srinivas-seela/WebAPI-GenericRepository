using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComp.EMS.Repositories.Models
{
    public class Vertical
    {
        public int VerticalID { get; set; }
        public string VerticalName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastedUpdatedDate { get; private set; }
        public string LastUpdatedBy { get; set; }
        public bool ActiveStatus { get; set; }

        public Vertical()
        {
            CreatedDate = DateTime.Now;
            LastedUpdatedDate = DateTime.Now;
        }
    }
}
