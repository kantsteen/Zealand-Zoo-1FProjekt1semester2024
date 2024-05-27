using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }

       

     
        public void OnGet() {
        }
        public void OnPost() {
         
         
        }
    }
}
