using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityDb.Entities
{
    public class Professor
    {
        [Key]
        public long ProfessorID { get; set; }

        // one to many(professor-class)
        public ICollection<UniversityClass> UniversityClasses { get; set; }
        

    }
}
