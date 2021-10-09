using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IS7012FinalProject_PackageTracking.Data;
using IS7012FinalProject_PackageTracking.Models;

namespace IS7012FinalProject_PackageTracking.Pages.TrackingNumbers
{
    public class CreateModel : PageModel
    {
        private readonly IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext _context;

        public CreateModel(IS7012FinalProject_PackageTracking.Data.IS7012FinalProject_PackageTrackingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["DelivererId"] = new SelectList(_context.Deliverer, "DelivererId", "DelivererName");
            ViewData["PackageId"] = new SelectList(_context.Package, "PackageId", "PackageName");
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "FullName");
            ViewData["TrackingNumberId"] = new SelectList(_context.User, "TrackingNumberId", "trackingNumber");
            return Page();
        }

        [BindProperty]
        public TrackingNumber TrackingNumber { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TrackingNumber.Add(TrackingNumber);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
