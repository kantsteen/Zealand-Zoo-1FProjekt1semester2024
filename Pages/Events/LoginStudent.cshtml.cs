
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
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                var students = LoadStudent();
                students.Add(Student);
                SaveStudents(students);
                HttpContext.Session.SetString("Name", Student.Name);
                return RedirectToPage("ReadAllEventsStudent");
            }
            else
            {
                Message = "Invalid name or Id.";
                return Page();
            }
        }

        private void SaveStudents(List<Student> students) {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonData = JsonSerializer.Serialize(students, options);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "Students.json");
            System.IO.File.WriteAllText(filePath, jsonData);
        }
    }
}
