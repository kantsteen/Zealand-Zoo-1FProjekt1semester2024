using Zealand_Zoo_1FProjekt1semester2024.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
