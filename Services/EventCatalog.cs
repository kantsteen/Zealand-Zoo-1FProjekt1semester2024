using Zealand_Zoo_1FProjekt1semester2024.Interface;

namespace Zealand_Zoo_1FProjekt1semester2024.Services
{
    public class EventCatalog : IEventRepository
    {

        private Dictionary<int, Event> events { get; }
















        public Dictionary<int, Event> AllEvents()
        {
            return events;
        }







    }
}
