using University.Contract.IEntityRepository;
using UniversityDb;
using UniversityDb.Entities;

namespace Repository.EntityRepository
{
    public class EnrollRepository : RepositoryBase<Enroll>, IEnrollRepository
    {
        public EnrollRepository(UniversityDbContext Context) : base(Context) { }
    }

}
