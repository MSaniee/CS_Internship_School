using School.Domain;
using School.Domain.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Services
{
    public class StudentService1 : IStudentService
    {
        public void MoveToHome(Student student)
        {
            Console.WriteLine("line 1");
        }
    }
}
