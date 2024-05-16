using System.ComponentModel.DataAnnotations;

namespace Zealand_Zoo_1FProjekt1semester2024.Models
{
    public class Student
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "Alder")]
        [Range(typeof(int), "16", "100",
        ErrorMessage = "Må kun indeholde tal")]
        public int Age { get; set; }

        public bool Gender { get; set; }

    }
}
