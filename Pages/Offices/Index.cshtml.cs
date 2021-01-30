using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OfficeChecker.Data;
using OfficeChecker.Models;

namespace OfficeChecker.Pages.Offices
{
    public class IndexModel : PageModel
    {
        private readonly OfficeChecker.Data.OfficeContext _context;

        public IndexModel(OfficeChecker.Data.OfficeContext context)
        {
            _context = context;
        }
        public Office Office { get; set; }

        public string Pinned { get; set; }

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

            ViewData["pagenum"] = id; 

            switch (id)
            {
                case 1:
                    ViewData["Pinned1"] = Pinned;                    
                    break;
                case 2:
                    ViewData["Pinned1"] = Pinned;
                    break;
                case 3:
                    ViewData["Pinned1"] = Pinned;
                    break;
                case 4:
                    ViewData["Pinned1"] = Pinned;
                    break;
                case 5:
                    ViewData["Pinned1"] = Pinned;
                    break;
                default:
                    ViewData["Pinned1"] = Pinned;
                    break;
            }

            switch (Office.LocationType)
            {
                case locationType.Business:
                    ViewData["LocationLabel"] = "Business Center";                    
                    break;
                case locationType.Delivery_Center:
                    ViewData["LocationLabel"] = "Delivery Center";
                    break;
                case locationType.Innovation:
                    ViewData["LocationLabel"] = "Innovation Center";
                    break;
                case locationType.Corporate:
                    ViewData["LocationLabel"] = "Corporate Center";
                    break;
                default:
                    ViewData["LocationLabel"] = "";
                    break;
            }

            switch (Office.OfficeStatus)
            {
                case officeStatus.Closed:
                    ViewData["StatusLabel"] = "Closed";                    
                    break;
                case officeStatus.By_Invitation_Only:
                    ViewData["StatusLabel"] = "By Invitation Only";
                    break;
                case officeStatus.Reservation_Required:
                    ViewData["StatusLabel"] = "Reservation Required";
                    break;
                case officeStatus.Business_As_Usual:
                    ViewData["StatusLabel"] = "Business As Usual";
                    break;
                default:
                    ViewData["StatusLabel"] = "";
                    break;
            }
            
            switch (Office.TemperatureChecking)
            {
                case temperatureChecking.Conducting_Employee_selfCheck:
                    ViewData["TempLabel"] = "Conducting - Employee Self-Check";                    
                    break;
                case temperatureChecking.Conducting_by_Accenture:
                    ViewData["TempLabel"] = "Conducting - By Accenture";
                    break;
                case temperatureChecking.Conducting_by_building_not_Accenture:
                    ViewData["TempLabel"] = "Conducting - By Building (Not_Accenture)";
                    break;
                case temperatureChecking.Not_Conducting:
                    ViewData["TempLabel"] = "Not Conducting";
                    break;
                default:
                    ViewData["TempLabel"] = "";
                    break;
            }

            

            if(Office.PhysicalDistancing == true)
            {
                ViewData["DistLabel"] = "Required";
            }
            else
            {
                ViewData["DistLabel"] = "Not Required";                
            }

            if(Office.ReservableSpace == true)
            {
                ViewData["ReservLabel-Home"] = "Available";
            }
            else
            {
                ViewData["ReservLabel-Home"] = "Not Available";                
            }

            switch (Office.TechSupport)
            {
                case techSupport.Yes:
                    ViewData["TechLabel-Home"] = "Available";                    
                    break;
                case techSupport.Reservation_Only:
                    ViewData["TechLabel-Home"] = "Reservation Required";
                    break;
                default:
                    ViewData["TechLabel-Home"] = "Unavailable";
                    break;
            }
            
            if(id == 1)
            {
                ViewData["HomeLabel"] = "Home Office";
            }
            else
            {
                ViewData["HomeLabel"] = "Pinned Office";                
            }

            return Page();
        }
    }
}