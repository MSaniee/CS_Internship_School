using School.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Services
{
    public class StudentService2 : IStudentService
    {
        public void MoveToHome(Student student)
        {
            Console.WriteLine("line 2");
        }
    }
}
