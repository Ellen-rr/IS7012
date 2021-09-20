using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatYumy.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }

        [DisplayName("Industry Name")]
        [Required]
        public string IndustryName { get; set; }
        
        [StringLength(20, ErrorMessage = "The industryName should not exceed 20 ")]
        public List<Company> Companies { get; set; }
        public List<Candidate> Candidates { get; set; }

        [DisplayName("Industry Register")]
        [Required]
        public bool IndustryRegister { get; set; }

    }
}
