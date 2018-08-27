using System;
using System.ComponentModel.DataAnnotations;
using MyComp.EMS.Data.Interfaces;

namespace MyComp.EMS.Data.Entities
{
    public class Account : BaseEntity
    {
        [Key]
        public int AccountID { get; set; }

        [Required][StringLength(50)]
        public string AccountName { get; set; }
        [Required]
        public int VerticalID { get; set; }
        public Vertical Vertical { get; set; }

        [Required]
        [StringLength(15)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        [StringLength(15)]
        public string LastUpdatedBy { get; set; }
        [Required]
        public DateTime LastedUpdatedDate { get; set; }

        [Required]
        public bool ActiveStatus { get; set; }
    }
}
