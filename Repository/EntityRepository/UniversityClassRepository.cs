using University.Contract.IEntityRepository;
using UniversityDb;
using UniversityDb.Entities;

namespace Repository.EntityRepository
{
    public class UniversityClassRepository : RepositoryBase<UniversityClass> , IUniversityClassRepository
    {
        public UniversityClassRepository(UniversityDbContext Context) : base(Context) { }
    }
}
