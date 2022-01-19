using University.Contract.IEntityRepository;
using UniversityDb;
using UniversityDb.Entities;

namespace Repository.EntityRepository
{
    public class StudentRepository : RepositoryBase<Student> , IStudentRepository
    {
        public StudentRepository (UniversityDbContext Context) : base(Context) { }
    }
}
