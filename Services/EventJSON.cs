using Microsoft.Extensions.Logging;
using Zealand_Zoo_1FProjekt1semester2024.Helpers;
using Zealand_Zoo_1FProjekt1semester2024.Interface;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Newtonsoft.Json;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using Microsoft.AspNetCore.Hosting;



namespace Zealand_Zoo_1FProjekt1semester2024.Services
{
    public class EventJSON : IEventRepository
    {
        public EventJSON(IWebHostEnvironment webHostEnvironment) {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "JSONEvents.json"); }
        }


        //string JsonFileName = @"C:\Users\Daniyal\source\repos\Zealand-Zoo-1FProjekt1semester2024\Data\JSON Events.json";


        public void AddEvent(Event newEvent)
        {
            Dictionary<int, Event> events = AllEvents();
            try
            {
                events.Add(newEvent.Id, newEvent);
            }
            catch (Exception ex) 
            {
                throw;
            
            }
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
                JSONFileWriter.WriteToJson(events, JsonFileName);
            }
        }

        public void DeleteEvent(Event evt)
        {
           

            if (evt != null)
            {
                Dictionary<int, Event> events = AllEvents();
                events.Remove(evt.Id);
                JSONFileWriter.WriteToJson(events, JsonFileName);
            }
        }
    }
}
