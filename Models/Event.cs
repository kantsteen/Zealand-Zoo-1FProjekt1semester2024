namespace Zealand_Zoo_1FProjekt1semester2024.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Limit { get; set; }

        public TimeSpan OpeningHours { get; set; }

        public string ImageName { get; set; }


    }
}
