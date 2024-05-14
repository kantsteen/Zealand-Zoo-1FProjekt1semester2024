using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class UpdateEventModel(Interface.IEventRepository repository) : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }
        private Interface.IEventRepository catalog = repository;

        public void OnGet(int id)
        {
            Event = catalog.GetEvent(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.UpdateEvent(Event);
            return RedirectToPage("ReadEvent");
        }
}
