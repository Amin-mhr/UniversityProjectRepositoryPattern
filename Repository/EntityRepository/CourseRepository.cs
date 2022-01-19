using University.Contract.IEntityRepository;
using UniversityDb;
using UniversityDb.Entities;

namespace Repository.EntityRepository
{
    public class CourseRepository : RepositoryBase<Course> , ICourseRepository
    {
        public CourseRepository(UniversityDbContext Context) : base (Context){ }
    }
}
