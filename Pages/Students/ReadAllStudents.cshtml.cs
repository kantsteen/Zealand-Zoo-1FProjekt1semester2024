using Microsoft.AspNetCore.Mvc.RazorPages;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Zealand_Zoo_1FProjekt1semester2024.Services;
using System.Collections.Generic;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Students
{
    public class ReadAllStudentsModel : PageModel
    {
        public StudentJSON _studentJSON;
       
        public IEnumerable<Student> Students { get; private set; }

        public ReadAllStudentsModel(StudentJSON studentJSON) {
            _studentJSON = studentJSON;
        }

        public void OnGet() {
            Students = _studentJSON.GetStudent();
        }
    }
}
