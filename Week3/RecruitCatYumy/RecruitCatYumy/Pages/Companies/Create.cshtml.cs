using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatYumy.Data;
using RecruitCatYumy.Models;

namespace RecruitCatYumy.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatYumy.Data.RecruitCatYumyContext _context;

        public CreateModel(RecruitCatYumy.Data.RecruitCatYumyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["WelcomeMessage"] = "Welcome, please add company!";
        ViewData["IndustryId"] = new SelectList(_context.Industry, "IndustryId", "IndustryName");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
