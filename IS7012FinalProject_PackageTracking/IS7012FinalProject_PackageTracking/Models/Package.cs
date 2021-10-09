using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS7012FinalProject_PackageTracking.Models
{
    public class Package
    {
        [Key]
        [Display(Name = "Package Id")]
        public int PackageId { get; set; }

        [Display(Name = "Package Content")]
        [Required(ErrorMessage = "What inside this package? It is required.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Input at least 1 characters")]
        public string PackageName { get; set; }


        [Display(Name = "Package Weight")]
        [Required(ErrorMessage = "Package Weight is required.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Input at least 1 characters")]
        public string PackageWeight { get; set; }

        [Display(Name = "User")]
        public User User { get; set; }
        public int UserId { get; set; }

        [Display(Name = "Deliverer's name")]
        public Deliverer Deliverer { get; set; }
        public int? DelivererId { get; set; }
        
    }
}
