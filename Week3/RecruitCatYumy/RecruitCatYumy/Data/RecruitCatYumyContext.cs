using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatYumy.Models;

namespace RecruitCatYumy.Data
{
    public class RecruitCatYumyContext : DbContext
    {
        public RecruitCatYumyContext (DbContextOptions<RecruitCatYumyContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatYumy.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatYumy.Models.Company> Company { get; set; }

        public DbSet<RecruitCatYumy.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatYumy.Models.JobTitle> JobTitle { get; set; }
    }
}
