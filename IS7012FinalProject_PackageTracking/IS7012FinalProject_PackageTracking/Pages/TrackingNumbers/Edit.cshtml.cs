using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IS7012FinalProject_PackageTracking.Data;
using IS7012FinalProject_PackageTracking.Models;

namespace IS7012FinalProject_PackageTracking.Pages.TrackingNumbers
{
    public class EditModel : PageModel
    {
        private readonly IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext _context;

        public EditModel(IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TrackingNumber TrackingNumber { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TrackingNumber = await _context.TrackingNumber
                .Include(t => t.Deliverer)
                .Include(t => t.Package)
                .Include(t => t.User).FirstOrDefaultAsync(m => m.TrackingNumberId == id);

            if (TrackingNumber == null)
            {
                return NotFound();
            }
           ViewData["DelivererId"] = new SelectList(_context.Deliverer, "DelivererId", "DelivererName");
           ViewData["PackageId"] = new SelectList(_context.Package, "PackageId", "PackageName");
           ViewData["UserId"] = new SelectList(_context.User, "UserId", "FullName");
           ViewData["TrackingNumberId"] = new SelectList(_context.User, "TrackingNumberId", "trackingNumber");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TrackingNumber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrackingNumberExists(TrackingNumber.TrackingNumberId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TrackingNumberExists(int id)
        {
            return _context.TrackingNumber.Any(e => e.TrackingNumberId == id);
        }
    }
}
