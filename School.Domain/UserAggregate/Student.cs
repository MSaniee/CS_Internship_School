using School.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.UserAggregate
{
    public class Student : BaseEntity<int>
    {
        public Student()
        {

        }

        public Student(string name)
        {
            Name = name;
        }

        public  string Name { get; set; }
        public bool FinalExam { get; set; }
        public int FinalExamScore { get; set; }
    }
}
