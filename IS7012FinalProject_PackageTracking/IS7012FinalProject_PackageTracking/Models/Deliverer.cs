using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS7012FinalProject_PackageTracking.Models
{
    public class Deliverer
    {
        [Key]
        [Display(Name = "Deliverer Id")]
        public int DelivererId { get; set; }

        [Display(Name = "Deliverer's Code")]
        [Required(ErrorMessage = "Code is required.")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Input at least 5 characters")]
        public string DelivererCode { get; set; }


        [Display(Name = "Deliverer's Name")]
        [Required(ErrorMessage = "Code is required.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Input at least 1 characters")]
        public string DelivererName { get; set; }

        public List<Package> Packages { get; set; }
            
        [Required]
        [CustomValidation(typeof(Deliverer), "DateValidation")]
        [Display(Name = "Delivered Date")]
        [DataType(DataType.Date)]
        public DateTime? DateDelivered { get; set; }


        public static ValidationResult DateValidation(DateTime? DateDelivered, ValidationContext context)
        {
            if (DateDelivered == null)
            {
                return ValidationResult.Success;
            }
            if (DateDelivered < DateTime.Now)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Delivered date must be before current time");
        }

        [Display(Name = "Delivery Status")]
        public bool DeliveryStatus { get; set; }

    }
}
