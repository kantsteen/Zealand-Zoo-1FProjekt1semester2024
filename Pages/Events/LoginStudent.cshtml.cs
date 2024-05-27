
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class LoginStudentModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }

        public string Message { get; set; }

        public bool StudentExists { get; set; } = true; // Assume student exists unless proven otherwise

        private List<Student> LoadStudent()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "Students.json");
            if (System.IO.File.Exists(filePath))
            {
                var jsonData = System.IO.File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<Student>>(jsonData);
            }
            else
            {
                return new List<Student>();
            }
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var students = LoadStudent();
                var existingStudent = students.FirstOrDefault(s => s.Id == Student.Id && s.Name == Student.Name);
                if (existingStudent != null)
                {
                    // Student exists, log in
                    HttpContext.Session.SetString("Name", Student.Name);
                    return RedirectToPage("ReadAllEventsStudent");  // Redirect to the main page after login
                }
                else
                {
                    Message = "No such student found. Please create a new account.";
                    return Page(); // Stay on the login page to show the message
                }
            }
            else
            {
                Message = "Invalid name or Id.";
                return Page();
            }
        }

    }
}
