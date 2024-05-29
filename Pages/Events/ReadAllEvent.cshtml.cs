using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using System.Collections.Generic;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class ReadEventModel : BasePageModelModel
    {
        private IEventRepository catalog;
        public ReadEventModel(IEventRepository evt)
        {
            catalog = evt;
            
        }
        public Dictionary<int, Event> Events { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        
        public IActionResult OnGet()
        {
            CheckAdminLogin(); // Ensure the user is authenticated
            Events = catalog.AllEvents();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Events = catalog.FilterEvent(FilterCriteria);
            }

            return Page();
        }











    }
    
    
    
}
