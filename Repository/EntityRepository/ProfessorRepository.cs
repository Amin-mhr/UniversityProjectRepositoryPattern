using University.Contract.IEntityRepository;
using UniversityDb;
using UniversityDb.Entities;

namespace Repository.EntityRepository
{
    public class ProfessorRepository : RepositoryBase<Professor> , IProfessorRepository 
    {
        public ProfessorRepository(UniversityDbContext Context) : base(Context) { }
    }
}
