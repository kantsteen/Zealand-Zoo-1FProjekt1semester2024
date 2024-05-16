using Microsoft.Extensions.Logging;
using Zealand_Zoo_1FProjekt1semester2024.Helpers;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;



namespace Zealand_Zoo_1FProjekt1semester2024.Services
{
    public class EventJSON : IEventRepository
    {
        string JsonFileName = @"C:\Users\Daniyal\source\repos\Zealand-Zoo-1FProjekt1semester2024\Data\JSON Events.json";


        public void AddEvent(Event newEvent)
        {
            Dictionary<int, Event> events = AllEvents();
            events.Add(newEvent.Id, newEvent);
            JSONFileWriter.WriteToJson(events, JsonFileName);
        }

        public Dictionary<int, Event> AllEvents()
        {
            return JSONFileReader.ReadJson(JsonFileName);
        }

        public Dictionary<int, Event> FilterEvent(string criteria)
        {
            Dictionary<int, Event> events = AllEvents();
            Dictionary<int, Event> filteredEvents = new Dictionary<int, Event>();
            foreach (var e in events.Values)
            {
                if (e.Name.StartsWith(criteria))
                {
                    filteredEvents.Add(e.Id, e);
                }
            }
            return filteredEvents;
        }

        public Event ReadEvent(int Id)
        {
            Dictionary<int, Event> events = AllEvents();

            foreach (var e in events)
            {
                if (e.Key == Id)
                    return e.Value;
            }
            return new Event();
        }

        public void UpdateEvent(Event evt)
        {
            Dictionary<int, Event> events = AllEvents();

            if (evt != null)
            {
                events[evt.Id] = evt;
            }
        }

        public void DeleteEvent(Event evt)
        {
            Dictionary<int, Event> events = AllEvents();

            if (evt != null)
            {
                events.Remove(evt.Id);
            }
        }
    }
}
