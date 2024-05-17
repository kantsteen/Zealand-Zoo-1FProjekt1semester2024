using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Interface
{
    public interface IEventRepository
    {
        Dictionary<int, Event> AllEvents();

        Dictionary<int, Event> FilterEvent(string crtiteria);

        void DeleteEvent(int id);

        void AddEvent(Event evt);

        void UpdateEvent(Event evt);

        public Event ReadEvent(int id);

    }
}
