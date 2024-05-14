using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Helpers
{
    public class JSONFileWriter
    {
        public static void WriteToJson(Dictionary<int, Event> events, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(events, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }

    }
}
