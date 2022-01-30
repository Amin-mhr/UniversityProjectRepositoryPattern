using Repository.EntityRepository;
using University.Contract;
using University.Contract.IEntityRepository;
using UniversityDb;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private UniversityDbContext _context ;
        private IAdminRepository _admin;
        private ICourseRepository _course;
        private IEnrollRepository _enroll;
        private IProfessorRepository _professor;
        private IStudentRepository _student;
        private IUniversityClassRepository _universityClass;

        public IAdminRepository Admin {
            get {
                if (_admin == null)
                {
                    _admin = new AdminRepository(_context);
                }
                return _admin;
            } 
        }

        public ICourseRepository Course {
            get
            {
                if (_course == null)
                {
                    _course = new CourseRepository(_context);
                }
                return _course;
            }
        }

        public IEnrollRepository Enroll
        {
            get
            {
                if (_enroll == null)
                {
                    _enroll = new EnrollRepository(_context);
                }
                return _enroll;
            }
        }

        public IProfessorRepository Professor
        {
            get
            {
                if (_professor == null)
                {
                    _professor = new ProfessorRepository(_context);
                }
                return _professor;
            }
        }

        public IStudentRepository Student
        {
            get
            {
                if (_student == null)
                {
                    _student = new StudentRepository(_context);
                }
                return _student;
            }
        }

        public IUniversityClassRepository UniversityClass
        {
            get
            {
                if (_universityClass == null)
                {
                    _universityClass = new UniversityClassRepository(_context);
                }
                return _universityClass;
            }
        }

        public RepositoryWrapper(UniversityDbContext Context)
        {
            _context = Context; 
        }

        public void save()
        {
            _context.SaveChanges(); 
        }
    }
}
