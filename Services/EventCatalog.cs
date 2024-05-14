using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Services
{
    public class EventCatalog : IEventRepository
    {

        private Dictionary<int, Event> events { get; }

        public EventCatalog()
        {
            events = new Dictionary<int, Event>();
            events.Add(1, new Event() { Id = 1, Name = "Fredagsbar", Description = "Dødsdruk", Limit = 50, OpeningTime = new DateTime(2024, 5, 14, 14, 0, 0), ClosingTime = new DateTime(2024, 5, 14, 17, 0, 0), ImageName = "Fredagsbar.jfif" });
            events.Add(2, new Event() { Id = 2, Name = "Nat Bowling", Description = "yay", Limit = 25, OpeningTime = new DateTime(2024, 5, 15, 22, 0, 0), ClosingTime = new DateTime(2024, 5, 15, 01, 0, 0), ImageName = "Bowling.jfif" });
            events.Add(3, new Event() { Id = 3, Name = "Festival", Description = "Sommer hygge", Limit = 250, OpeningTime = new DateTime(2024, 5, 16, 14, 0, 0), ClosingTime = new DateTime(2024, 5, 16, 22, 0, 0), ImageName = "Festival.jfif" });
            events.Add(4, new Event() { Id = 4, Name = "Champions league finale", Description = "Vi skal se fodbold", Limit = 100, OpeningTime = new DateTime(2024, 5, 17, 19, 0, 0), ClosingTime = new DateTime(2024, 5, 17, 21, 0, 0), ImageName = "Fodbold.jfif" });
            events.Add(5, new Event() { Id = 5, Name = "Brætspil aften", Description = "Ludooooo", Limit = 30, OpeningTime = new DateTime(2024, 5, 18, 16, 0, 0), ClosingTime = new DateTime(2024, 5, 18, 20, 0, 0), ImageName = "Brætspil.jfif" });
        }
















        public Dictionary<int, Event> AllEvents()
        {
            return events;
        }

        public void UpdateEvent(Event event)
        {
            if (event != null)
            {
                events[event.Id] = event; 
            }

<<<<<<< HEAD


        public Event GetEvent(int id)
        {
            return events[id];
        }


=======
        }
>>>>>>> 0fe6cb352fba765292bf7a77c965c0e92656607f
    }
}

