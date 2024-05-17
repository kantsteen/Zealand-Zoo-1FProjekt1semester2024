using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class UpdateEventModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }
        private IEventRepository catalog;
        public UpdateEventModel(IEventRepository repository) {
            catalog = repository;
        }
        public void OnGet(int id) {
            Event = catalog.ReadEvent(id);
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.UpdateEvent(Event);
            return RedirectToPage("ReadAllEvent");
        }
    }
}
