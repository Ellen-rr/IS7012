using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RecruitCatYumy.Models
{
    public class Candidate
    {
        
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public DateTime? StartDate { get; set; }
        public String PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

    }

}
