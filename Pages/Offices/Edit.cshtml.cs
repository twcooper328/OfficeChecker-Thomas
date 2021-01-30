using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeChecker.Data;
using OfficeChecker.Models;

namespace OfficeChecker.Pages.Offices
{
    public class EditModel : PageModel
    {
        private readonly OfficeChecker.Data.OfficeContext _context;

        public EditModel(OfficeChecker.Data.OfficeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Office Office { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
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

            ViewData["integer test"] = Office.OfficeName;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Office).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfficeExists(Office.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/SitePages/EditList");
        }

        private bool OfficeExists(int id)
        {
            return _context.Office.Any(e => e.ID == id);
        }
    }
}