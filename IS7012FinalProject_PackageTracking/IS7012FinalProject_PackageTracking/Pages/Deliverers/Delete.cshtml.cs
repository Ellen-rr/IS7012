using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IS7012FinalProject_PackageTracking.Data;
using IS7012FinalProject_PackageTracking.Models;

namespace IS7012FinalProject_PackageTracking.Pages.Deliverers
{
    public class DeleteModel : PageModel
    {
        private readonly IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext _context;

        public DeleteModel(IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Deliverer Deliverer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deliverer = await _context.Deliverer.FirstOrDefaultAsync(m => m.DelivererId == id);

            if (Deliverer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deliverer = await _context.Deliverer.FindAsync(id);

            if (Deliverer != null)
            {
                _context.Deliverer.Remove(Deliverer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
