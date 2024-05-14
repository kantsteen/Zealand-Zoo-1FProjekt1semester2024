using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Interface
{
    public interface IEventRepository
    {
        Dictionary<int, Event> AllEvents();

        void DeleteEvent(Event evt);

        void AddEvent(Event evt);

        void UpdateEvent(Event evt);

        public Event GetEvent(int id);

    }
}
