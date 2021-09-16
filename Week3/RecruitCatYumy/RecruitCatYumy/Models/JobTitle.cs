using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatYumy.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string TheJobTitle { get; set; }
        public decimal MinimumSalary { get; set; }
        public List<Candidate> Candidates { get; set; }
        public decimal MaximumSalary { get; set; }

    }

}
