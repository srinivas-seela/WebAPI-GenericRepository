using System;
using System.ComponentModel.DataAnnotations;
using MyComp.EMS.Data.Interfaces;

namespace MyComp.EMS.Data.Entities
{
    public class Vertical : BaseEntity
    {
        [Key]
        public int VerticalID { get; set; }
        [Required][StringLength(50)][MinLength(3)]
        public string VerticalName { get; set; }

        [Required]
        [StringLength(15)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get;  set; }
        [Required]
        public DateTime LastedUpdatedDate { get; set; }
        [Required]
        [StringLength(15)]
        public string LastUpdatedBy { get; set; }

        [Required]
        public bool ActiveStatus { get; set; }

       
    }
}
