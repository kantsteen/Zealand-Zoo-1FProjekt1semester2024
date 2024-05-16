using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class DeleteEventModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }
        private IEventRepository catalog;
        public DeleteEventModel(IEventRepository repository)
        {
            catalog = repository;
        }


        public IActionResult OnGet(int id)
        {
            Event = catalog.ReadEvent(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            catalog.DeleteEvent(Event);
            return RedirectToPage("GetAllEvents");
        }
        
    }
}
