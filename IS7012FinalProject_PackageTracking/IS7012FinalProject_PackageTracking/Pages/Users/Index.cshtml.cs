using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IS7012FinalProject_PackageTracking.Data;
using IS7012FinalProject_PackageTracking.Models;

namespace IS7012FinalProject_PackageTracking.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext _context;

        public IndexModel(IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
