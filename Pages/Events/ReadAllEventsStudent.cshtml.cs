using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Security.Claims;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Zealand_Zoo_1FProjekt1semester2024.Services;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class ReadAllEventModelStudents : BasePageStudentModel
    {
        private IEventRepository catalog;
        public StudentJSON _studentJSON;

        public IEnumerable< Student > Students { get; set; }

        public ReadAllEventModelStudents(IEventRepository evt, StudentJSON studentJSON)
        {
            catalog = evt;
            _studentJSON = studentJSON;
            


        }
        public Dictionary<int, Event> Events { get; set; }

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }


        public IActionResult OnGet()
        {
            Students = new List<Student>(); // Initialize to an empty list to prevent null reference errors
            var studentId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;                                                                       

            if (!string.IsNullOrEmpty(studentId))
            {
                var loggedInStudent = _studentJSON.GetStudentById(studentId);
                if (loggedInStudent != null)
                {
                    Students = new List<Student> { loggedInStudent };
                }
            }
            CheckLogin(); // Ensure the user is authenticated   

            Events = catalog.AllEvents();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Events = catalog.FilterEvent(FilterCriteria);

            }

            return Page();
        }



    }
}