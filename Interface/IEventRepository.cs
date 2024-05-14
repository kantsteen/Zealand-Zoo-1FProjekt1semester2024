using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Interface
{
    public interface IEventRepository
    {
        Dictionary<int, Event> AllEvents();

        void DeleteEvent(Event event);

        void AddEvent(Event event);

        void UpdateEvent(Event event);

        public Event GetEvent(int id);

    }
}
