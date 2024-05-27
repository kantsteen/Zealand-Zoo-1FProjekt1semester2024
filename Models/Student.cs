using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Zealand_Zoo_1FProjekt1semester2024.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }


        //public override string ToString() => JsonSerializer.Serialize<Student>(this);


    }
}
