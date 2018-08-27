using System;
using System.ComponentModel.DataAnnotations;
using MyComp.EMS.Data.Interfaces;

namespace MyComp.EMS.Data.Entities
{
    public class Project : BaseEntity
    {
        [Key]
        public int ProjectID { get; set; }
        [Required] [StringLength(100)]
        public string ProjectName { get; set; }
        [Required]
        public DateTime ProjectStartDate { get; set; }

        public DateTime ProjectEndDate { get; set; }
        [Required]
        public Int16 BillabilityCount { get; set; }

        [Required][StringLength(20)]
        public string ProjectExecutionLocation { get; set; }
        [Required]
        public int AccountID { get; set; }
        public Account Account { get; set; }
        [Required]
        [StringLength(15)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime LastedUpdatedDate { get; set; }
        [Required]
        [StringLength(15)]
        public string LastUpdatedBy { get; set; }
        [Required]
        public bool ActiveStatus { get; set; }
    }
}
