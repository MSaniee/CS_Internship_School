using School.Domain.UserAggregate;

namespace School.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository, IDisposable
    {

        public StudentRepository(List<Student> db) : base(db)
        {

        }

        public override void Add(Student entity)
        {
            entity.Name += "Test";
        }

        public void Dispose()
        {
            //Close Connection
        }

        public Student GetById(int id)
        {
            return _db.FirstOrDefault(s => s.Id == id);
        }
    }
}
