using System.Text.Json;
using Zealand_Zoo_1FProjekt1semester2024.Models;

namespace Zealand_Zoo_1FProjekt1semester2024.Services
{
    public class StudentJSON
    {

        public StudentJSON(IWebHostEnvironment webHostEnvironment) {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Student.json"); }
        }

        public IEnumerable<Student> GetStudent() {
            using (var jsonFileReader = File.OpenText(JsonFileName))
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

            using (var jsonFileWriter = new StreamWriter(JsonFileName))
            {
                jsonFileWriter.Write(jsonString);
            }
        }
    }
}

