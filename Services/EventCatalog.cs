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
            events.Add(1, new Event() { Id = 1, Name = "Fredagsbar", Description = "Dødsdruk", Limit = 50, OpeningHours = new TimeSpan(2,30,10), ImageName = "Fredagsbar.jfif" });
            events.Add(2, new Event() { Id = 2, Name = "Nat Bowling", Description = "yay", Limit = 25, OpeningHours = new TimeSpan(3, 0, 0), ImageName = "Bowling.jfif" });
            events.Add(3, new Event() { Id = 3, Name = "Festival", Description = "Sommer hygge", Limit = 250, OpeningHours = new TimeSpan(7, 30, 0), ImageName = "Festival.jfif" });
            events.Add(4, new Event() { Id = 4, Name = "Champions league finale", Description = "Vi skal se fodbold", Limit = 100, OpeningHours = new TimeSpan(2, 0, 0), ImageName = "Fodbold.jfif" });
            events.Add(5, new Event() { Id = 5, Name = "Brætspil aften", Description = "Ludooooo", Limit = 30, OpeningHours = new TimeSpan(4, 0, 0), ImageName = "Brætspil.jfif" });
        }
















       
        
        
        
        
        
        
        
        
        
        public Dictionary<int, Event> AllEvents()
        {
            return events;
        }

        public void UpdateEvent(Event evt)
        {
            if (evt != null)
            {
                events[evt.Id] = evt;
            }
        }

        public void DeleteEvents(Event evt) 
        {
            if (evt != null)
            {
                events.Remove(evt.Id);
            }
            
        }


    }
}

