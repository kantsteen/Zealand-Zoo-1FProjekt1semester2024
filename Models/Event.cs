using System.ComponentModel.DataAnnotations;

namespace Zealand_Zoo_1FProjekt1semester2024.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Maks antal nødvendig")]
        [Range(typeof(int), "1", "250",
        ErrorMessage = "Værdi mellem 1 & 250 ")]
        public int Limit { get; set; }

        public DateTime OpeningTime { get; set; }

        public DateTime ClosingTime {  get; set; }

        public string ImageName { get; set; }

        
    }
}
