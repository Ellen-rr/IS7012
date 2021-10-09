using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IS7012FinalProject_PackageTracking.Data;
using IS7012FinalProject_PackageTracking.Models;

namespace IS7012FinalProject_PackageTracking.Pages.Packages
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
        ViewData["UserId"] = new SelectList(_context.User, "UserId", "FullName");
            return Page();
        }

        [BindProperty]
        public Package Package { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Package.Add(Package);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
