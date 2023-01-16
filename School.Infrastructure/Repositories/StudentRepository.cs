using School.Domain.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
