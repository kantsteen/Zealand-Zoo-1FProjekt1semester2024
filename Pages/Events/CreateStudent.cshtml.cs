using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Zealand_Zoo_1FProjekt1semester2024.Services;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class CreateStudentModel : PageModel
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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var students = LoadStudent();
                if (students.Any(s => s.Id == Student.Id))
                {
                    // If the student ID already exists, set an error message
                    Message = "This ID is already in use. Please use a different ID.";
                    return Page();
                }
                else
                {
                    // Add the new student as the ID is unique
                    students.Add(Student);
                    SaveStudents(students);
                    TempData["SuccessMessage"] = "Student created successfully!";
                    return RedirectToPage("ReadAllEventsStudent"); // Redirect after successful creation
                }
            }
            else
            {
                Message = "Please fill in all required fields correctly.";
                return Page();
            }
        }


        private void SaveStudents(List<Student> students)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonData = JsonSerializer.Serialize(students, options);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "Students.json");
            System.IO.File.WriteAllText(filePath, jsonData);
        }
    }
    /* public class CreateStudentModel : PageModel
     {
         private readonly ILogger<CreateStudentModel> _logger;
         private readonly StudentJSON _studentJSON;

         [BindProperty]
         public IEnumerable<Student> Student { get; set; }

         public CreateStudentModel(ILogger<CreateStudentModel> logger, StudentJSON studentJSON)
         {
             _logger = logger;
             _studentJSON = studentJSON;
         }

         public IActionResult OnGet()
         {
             return Page();
         }

         public IActionResult OnPost()
         {
             if (!ModelState.IsValid)
             {
                 return Page();
             }

             _studentJSON.SaveStudents(Student);
             return RedirectToPage("ReadAllStudents"); // Ensure this page exists or create it
         }
     }*/
}

