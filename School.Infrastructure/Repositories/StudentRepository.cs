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
            using ApplicationDbContext _dbContext = new();
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            //Close Connection
        }

        public bool IsAllStudentsPassedFinalExam()
        {
            return _db.All(s => s.FinalExam == true);
        }

        public Student? GetBestStudent()
        {
            return _db.MaxBy(s => s.FinalExamScore);
        }

        public List<Student> GetStudentsByOrder()
        {
            return _db.OrderBy(s => s.Name).ToList();
        }

        public int CountStudentsPassedFinalExam()
        {
            return _db.Where(s => s.FinalExam).Count();
        }

        public bool ExistsStudent(string name)
        {
            var result = _db.MyWhere(s => s.Name == name);

            return result.Count != 0;
        }

        public bool ExistsStudent(int id) => _db.Any(s => s.Id == id);


        public Student? GetById(int id)
        {
            return _db.FirstOrDefault(s => s.Id == id);
        }

        public List<Student> GetAllStudents()
        {
            return _db;
        }
    }

    public static class MyWhereExtentsion
    {
        public static List<T> MyWhere<T>(this List<T> list, MyPredicate<T> myPredicate)
        {
            List<T> result = new();

            foreach(var item in list)
            {
                if (myPredicate.Invoke(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }

    public delegate bool MyPredicate<T>(T t);
}
