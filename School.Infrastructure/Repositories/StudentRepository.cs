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

        //public override void Add(Student entity)
        //{
        //    entity.Name += "Test";
        //}

        public void Dispose()
        {
            //Close Connection
        }

        public bool ExistsStudent(string name)
        {
            var result = _db.MyWhere(s => s.Name == name);

            return result.Count != 0;
        }

        public bool ExistsStudent(int id)
        {
            var result = _db.MyWhere(s => s.Id == id);

            return result.Count != 0;
        }

        public List<Student> GetAllStudents()
        {
            return _db;
        }

        public Student GetById(int id)
        {
            return _db.FirstOrDefault(s => s.Id == id);
        }
    }


    public static class RepositoryExtensionMethods
    {
        
        public static List<T> MyWhere<T>(this List<T> list, MyPredicate<T> predicate)
        {
            List<T> result = new();

            foreach(var item in list)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }

    public delegate bool MyPredicate<T>(T t);
}
