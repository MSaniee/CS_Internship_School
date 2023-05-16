using School.Domain.UserAggregate;

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
                    FinalExam = true,
                    FinalExamScore = 14,
                },
                new()
                {
                    Id = 2,
                    Name = "Behzad",
                    FinalExam = false,
                    FinalExamScore = 15,
                },
                new()
                {
                    Id = 3,
                    Name = "Nima",
                    FinalExam = true,
                    FinalExamScore = 13,
                },
                new()
                {
                    Id = 4,
                    Name = "Peyman",
                    FinalExam = false,
                    FinalExamScore = 12,
                },
            };
        }
    }
}
