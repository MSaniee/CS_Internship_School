using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.UserAggregate
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetById(int Id);

        bool ExistsStudent(string name);

        List<Student> GetAllStudents();
    }
}
