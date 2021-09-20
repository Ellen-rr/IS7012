using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatYumy.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }

        [DisplayName("The Job Title")]
        [Required]
        
        [StringLength(20, ErrorMessage = "The job title value should not exceed 20 ")]
        public string TheJobTitle { get; set; }

        [DisplayName("Minimum Salary")]
        [Required]
        [Range(0, double.MaxValue)]
        public decimal MinimumSalary { get; set; }
        public List<Candidate> Candidates { get; set; }

        [DisplayName("Maximum Salary")]
        [Required]
        [Range(0, double.MaxValue)]
        public decimal MaximumSalary { get; set; }


    }

}
