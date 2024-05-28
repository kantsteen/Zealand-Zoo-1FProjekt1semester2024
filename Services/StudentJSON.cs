using System.Text.Json;
using Zealand_Zoo_1FProjekt1semester2024.Helpers;
using Zealand_Zoo_1FProjekt1semester2024.Models;
using System.Linq;
namespace Zealand_Zoo_1FProjekt1semester2024.Services
{
    public class StudentJSON
    {
        public Student GetStudentById(string studentId)
        {
            if (!int.TryParse(studentId, out int id))
            {
                return null; // Returns null if studentId is not a valid integer
            }

            var allStudents = AllStudent(); // Ensure this method correctly parses the JSON into a List<Student>
            return allStudents.FirstOrDefault(s => s.Id == id);
        }
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

