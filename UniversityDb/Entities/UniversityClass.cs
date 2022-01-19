using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityDb.Entities
{
    public class UniversityClass
    {
        public double AverageScore { get; set; }
        [Key]
        public long ClassId { get; set; }

        // one to many(student-class) 
        public ICollection<Student> Students { get; set; }

        // one to many (professor-class)
        public long? ProfessorID { get; set; }
        public Professor Professor { get; set; }
        // one to one (class-course)
        public Course Course { get; set; }
      
    }
}
