using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class UpdateEventModel : PageModel
    {
        [BindProperty]
        public Event Event { get; set; }
        private IEventRepository catalog;
        public UpdateEventModel(IEventRepository repository)
        {
            catalog = repository;
        }
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
