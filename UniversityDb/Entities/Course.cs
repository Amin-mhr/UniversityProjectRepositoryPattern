using System.ComponentModel.DataAnnotations;

namespace UniversityDb.Entities
{
    public class Course
    {
        public long NumberOfUnits { get; set; }
        [Key]
        public string Name { get; set; }

        //one to one (class- course)
        public long? ClassID { get; set; }
        public UniversityClass UniversityClass { get; set; }

    }
}
