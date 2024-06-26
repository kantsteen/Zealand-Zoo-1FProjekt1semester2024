using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class LoginModel : PageModel
    {
        [BindProperty]
       public Administrator Administrator { get; set; }

        public string Message { get; set; }

        private List<Administrator> LoadUsers()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot", "data", "Admin.json");
            var jsonData = System.IO.File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Administrator>>(jsonData);
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var users = LoadUsers();
            var user = users.Find(u => u.AdminName == Administrator.AdminName && u.Password == Administrator.Password);
            if (user != null)
            {
                HttpContext.Session.SetString("AdminName", user.AdminName);
                return RedirectToPage("ReadAllEvent");
            }
            else
            {
                Message = "Invalid name or password.";
                return Page();
            }
        }

    }
}
