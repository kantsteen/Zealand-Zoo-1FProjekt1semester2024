using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Zealand_Zoo_1FProjekt1semester2024.Services;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class CreateStudentModel : PageModel
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
    }
}

