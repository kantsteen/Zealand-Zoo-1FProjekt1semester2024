using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Zealand_Zoo_1FProjekt1semester2024.Services;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
     
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }
        
        public void OnGet()
        {
           
        }
       
      

     

    }
}
