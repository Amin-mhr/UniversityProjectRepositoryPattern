using University.Contract.IEntityRepository;
using UniversityDb;
using UniversityDb.Entities;

namespace Repository.EntityRepository
{
    public class AdminRepository : RepositoryBase<Admin> , IAdminRepository
    {
        public AdminRepository(UniversityDbContext Context)
            : base(Context) { }
    }
}
