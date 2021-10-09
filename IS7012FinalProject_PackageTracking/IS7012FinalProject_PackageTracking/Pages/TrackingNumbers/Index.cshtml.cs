using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IS7012FinalProject_PackageTracking.Data;
using IS7012FinalProject_PackageTracking.Models;

namespace IS7012FinalProject_PackageTracking.Pages.TrackingNumbers
{
    public class IndexModel : PageModel
    {
        private readonly IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext _context;

        public IndexModel(IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext context)
        {
            _context = context;
        }

        public IList<TrackingNumber> TrackingNumber { get;set; }

        public async Task OnGetAsync()
        {
            TrackingNumber = await _context.TrackingNumber
                .Include(t => t.Deliverer)
                .Include(t => t.Package)
                .Include(t => t.User).ToListAsync();
        }
    }
}
