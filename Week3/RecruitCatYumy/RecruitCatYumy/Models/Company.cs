using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatYumy.Models
{
    public class Company
    {
        
        public int CompanyId { get; set; }

        [DisplayName("Company Name")]
        [Required]
       
        [StringLength(20, ErrorMessage = "The Company Name should not exceed 20 ")]
        public string CompanyName { get; set; }

        [DisplayName("Position Name")]
        [Required]
       
        [StringLength(20, ErrorMessage = "The position Name should not exceed 20 ")]
        public string PositionName { get; set; }

        [DisplayName("Minimum Salary")]
        [Required]
        [Range(0, double.MaxValue)]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Required]
        [Range(0, double.MaxValue)]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Start Date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }

        
        [StringLength(20, ErrorMessage = "The location should not exceed 20 ")]
        public string Location { get; set; }

        [Range(0, double.MaxValue)]
        public decimal? Income { get; set; }

        [DisplayName("Number of Employee")]
        [Required]
        [Range(0, int.MaxValue)]
        public int NumberOfEmployee { get; set; }
    }
}
