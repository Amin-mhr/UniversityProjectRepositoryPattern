using System.Collections.Generic;

namespace UniversityDb.Entities
{
    public class Student
    {
        public long NumberOfUnits { get; set; }
        public double AverageScore { get; set; }
        public long StudentID { get; set; }

        // one to many.
        public UniversityClass? UniversityClass { get; set; }
        public long ClassCode { get; set; }

        //many to many(student-enroll)
        public ICollection<Enroll> enrolls { get; set; }

    }
}
