using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OfficeChecker.Data;
using OfficeChecker.Models;

namespace OfficeChecker.Pages.SitePages
{
    public class TestModel : PageModel
    {
        private readonly OfficeChecker.Data.OfficeContext _context;

        public TestModel(OfficeChecker.Data.OfficeContext context)
        {
            _context = context;
        }

        public Office Office { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id=1)
        {
            if (id == null)
            {
                return NotFound();
            }

            Office = await _context.Office.FirstOrDefaultAsync(m => m.ID == id);

            if (Office == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}