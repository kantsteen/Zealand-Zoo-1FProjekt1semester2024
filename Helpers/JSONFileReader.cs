using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Helpers
{
    public class JSONFileReader
    {
        public static Dictionary<int, Event> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<Dictionary<int, Event>>(jsonString);
        }
    }

    }
}
