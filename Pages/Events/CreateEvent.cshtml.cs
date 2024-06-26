using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository catalog;
        [BindProperty]
        public Event Event { get; set; }

        public string ErrorMsg { get; private set; } = "";

        public CreateEventModel(IEventRepository evt)
        {
            catalog = evt;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try 
            {
                catalog.AddEvent(Event);
            }
            catch (ArgumentException ex)
            { 
                ErrorMsg = ex.Message;
                return Page();

            }

            

            return RedirectToPage("ReadAllEvent");
        }
    }
}
