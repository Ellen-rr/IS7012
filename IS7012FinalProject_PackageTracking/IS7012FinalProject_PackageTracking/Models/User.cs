using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS7012FinalProject_PackageTracking.Models
{
    public class User
    {
        [Key]
        [Display(Name = "User Id")]
        public int UserId { get; set; }

        [Display(Name = "Deliverer's name")]
        public Deliverer Deliverer { get; set; }
        public int? DelivererId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Input at least 1 characters")]
        public string UserF { get; set; }
        

        
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Input at least 1 characters")]
        public string UserL { get; set; }
        

        
        [Display(Name = "Street")]
        [Required(ErrorMessage = "Street Name is required.")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Input at least 1 characters")]
        public string UserStreet { get; set; }
        

        
        [Display(Name = "Apt./Room")]
        public string UserRoom { get; set; }
        

        
        [Display(Name = "State")]
        [Required(ErrorMessage = "State is required.")]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "Input at least 1 characters")]
        public string UserState { get; set; }
        

        
        [Display(Name = "Zip-Code")]
        [Required(ErrorMessage = "Zip Code is required.")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Input at least 5 characters")]
        public string UserZip { get; set; }
        

        
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required.")]
        [StringLength(15, MinimumLength = 1, ErrorMessage = "Input at least 1 characters")]
        public string UserCountry { get; set; }
        

        [Display(Name = "Phone Number")]
        [Phone]
        public string UserPhone { get; set; }
        

        
        [Display(Name = "Email")]
        [EmailAddress]
        //string
        public string UserEmail { get; set; }

        [Required]
        [Display(Name = "Date Of Ship")]
        //datetime
        [DataType(DataType.Date)]
        public DateTime? DateOfShip { get; set; }


        [Display(Name = "User Full Name")]
        public string FullName => UserF + " " + UserL;

        [Display(Name = "User Address")]
        public string FullAddress => UserStreet + "\r\n" + UserRoom + "\r\n" + UserState + " " + UserCountry + " " + UserZip;

    }
}
