using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace RecruitCatYumy.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }

        [DisplayName("First Name")]
        [Required]
        [ScaffoldColumn(true)]
        [StringLength(20, ErrorMessage = "The First Name should not exceed 20 ")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        [ScaffoldColumn(true)]
        [StringLength(20, ErrorMessage = "The Last Name value should not exceed 20 ")]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        [Required]
        [Range(0, double.MaxValue)]
        public decimal TargetSalary { get; set; }
        
        public Company Company { get; set; }

        public int? CompanyId { get; set; }

        [DisplayName("Job Title")]
        

        public JobTitle JobTitle { get; set; }

        public int JobTitleId { get; set; }

        
        public Industry Industry { get; set; }

        public int IndustryId { get; set; }

        [DisplayName("Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        
        
        [DisplayName("Phone Number")]
        [Required]
        [StringLength(10, MinimumLength=10,ErrorMessage = "The phone number digit should be exactly 10 ")]

        public String PhoneNumber { get; set; }

   
        [StringLength(50, ErrorMessage = "The address value should not exceed 50 ")]
        public string Address { get; set; }
        [DisplayName("Date Of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

       



    }

}
