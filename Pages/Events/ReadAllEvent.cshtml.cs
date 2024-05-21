using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class ReadEventModel : PageModel
    {
        private IEventRepository catalog;
        private  User user;
        public ReadEventModel(IEventRepository evt, User usr)
        {
            catalog = evt;
            user = usr;
            
        }
        public Dictionary<int, Event> Events { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public bool IsAdmin { get { return user.Admin; } }

        public IActionResult OnGet()
        {
            Events = catalog.AllEvents();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Events = catalog.FilterEvent(FilterCriteria);
            }

            return Page();
        }











    }
    
    
    
}
