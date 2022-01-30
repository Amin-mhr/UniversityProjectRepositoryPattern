using University.Contract.IEntityRepository;


namespace University.Contract
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
