﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatYumy.Data;
using RecruitCatYumy.Models;

namespace RecruitCatYumy.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatYumy.Data.RecruitCatYumyContext _context;

        public DetailsModel(RecruitCatYumy.Data.RecruitCatYumyContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Industry = await _context.Industry.FirstOrDefaultAsync(m => m.IndustryId == id);

            if (Industry == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
