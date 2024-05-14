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
            events.Add(1, new Event() { Id = 1, Name = "Fredagsbar", Description = "Dødsdruk", Limit = 50, OpeningHours = new TimeSpan(14,0,0), ImageName = "Fredagsbar.jfif" });
        }




    }
}
