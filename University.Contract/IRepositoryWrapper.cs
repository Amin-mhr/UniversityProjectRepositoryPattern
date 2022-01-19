using System;
using System.Collections.Generic;
using System.Text;
using University.Repository.Interface;

namespace University.Repository
{
    public interface IRepositoryWrapper
    {
        IAdminRepository Admin { get; }
        ICourseRepository Course { get; }       
        IEnrollRepository Enroll { get; }   
        IProfessorRepository Professor { get; }
        IStudentRepository Student { get; }
        IUniversityClassRepository UniversityClass { get; }
        void save();
    }
}
