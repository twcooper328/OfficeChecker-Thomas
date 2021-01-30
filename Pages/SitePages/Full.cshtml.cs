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
    public class FullModel : PageModel
    {
        private readonly OfficeChecker.Data.OfficeContext _context;

        public FullModel(OfficeChecker.Data.OfficeContext context)
        {
            _context = context;
        }

        public string OfficeSort { get; set; }
        //public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        //public string CurrentSort { get; set; }

        public IList<Office> Offices { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            OfficeSort = String.IsNullOrEmpty(sortOrder) ? "office_desc" : "";

            CurrentFilter = searchString;
            
            IQueryable<Office> officesIQ = from s in _context.Offices
                                            select s;
            
            if (!String.IsNullOrEmpty(searchString))
            {
                officesIQ = officesIQ.Where(o => o.Address.ToUpper().Contains(searchString.ToUpper())
                || o.City.ToUpper().Contains(searchString.ToUpper())
                || o.State.ToUpper().Contains(searchString.ToUpper()) 
                || o.Zip.Contains(searchString) 
                || o.OfficeName.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "office_desc":
                    officesIQ = officesIQ.OrderByDescending(s => s.Address);
                    break;
                default:
                    officesIQ = officesIQ.OrderBy(s => s.Address);
                    break;
            }            

            Offices = await officesIQ.AsNoTracking().ToListAsync();
        }
    }
}