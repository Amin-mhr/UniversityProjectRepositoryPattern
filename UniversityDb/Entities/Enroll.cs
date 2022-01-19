using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityDb.Entities
{
    public class Enroll
    {
        public String ClassName { get; set; }
        [Key]
        public long ClassId { get; set; }
        public long PersonID { get; set; }

        //many to many(student-enroll)
        public ICollection<Student> Students { get; set; }
    }
}
