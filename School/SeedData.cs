using School.Domain.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SeedData
    {
        public static List<Student> GetSeedData()
        {
            return new()
            {
                new()
                {
                    Id = 1,
                    Name = "Mohsen",
                    FinalExam = true
                },
                new()
                {
                    Id = 2,
                    Name = "Behzad",
                    FinalExam = false
                },
                new()
                {
                    Id = 3,
                    Name = "Nima",
                    FinalExam = true
                },
                new()
                {
                    Id = 4,
                    Name = "Peyman",
                    FinalExam = true
                },
            };
        }
    }
}
