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
        public Administrator Administrator { get; set; }

        [BindProperty]
        /*public string Name { get; set; }

        [BindProperty]
        public string Password { get; set; }

        */public string Message { get; set; }

        private List<Administrator> LoadUsers()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot", "data", "Administrator.json");
            var jsonData = System.IO.File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Administrator>>(jsonData);
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var users = LoadUsers();
            var user = users.Find(u => u.Name == Administrator.Name && u.Password == Administrator.Password);
            if (user != null)
            {
                HttpContext.Session.SetString("Name", user.Name);
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
