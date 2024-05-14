using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class ReadEventModel : PageModel
    {
        private IEventRepository catalog;
        public ReadEventModel(IEventRepository Event)
        {
            catalog = Event;
        }
        public Dictionary<int, Event> Events { get; private set; }













    }
    
    
    
}
