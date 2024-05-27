using System.Text.Json;
using Zealand_Zoo_1FProjekt1semester2024.Helpers;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Services
{
    public class StudentJSON
    {

        public StudentJSON(IWebHostEnvironment webHostEnvironment) {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileNames
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Students.json"); }
        }
        public List<Student > AllStudent() {
            return JSONFileReader.ReadJson1(JsonFileNames);
        }
        public List<Student> FilterStudent(string criteria) {
            List<Student> students = AllStudent();
            List<Student> filteredEvents = new List<Student>();
            foreach (var e in students)
            {
                if (e.Name.StartsWith(criteria))
                {
                    filteredEvents.Add(e);
                }
            }
            return filteredEvents;
        }
        public IEnumerable<Student> GetStudent() {
            using (var jsonFileReader = File.OpenText(JsonFileNames))
            {
                return JsonSerializer.Deserialize<Student[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public void SaveStudents(IEnumerable<Student> students) {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(students, options);

            using (var jsonFileWriter = new StreamWriter(JsonFileNames))
            {
                jsonFileWriter.Write(jsonString);
            }
        }
       
      
    }
}

