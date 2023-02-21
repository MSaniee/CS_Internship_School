using School.Application.Interfaces;
using School.Domain.UserAggregate;

namespace School.Application.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepo;

    public StudentService(IStudentRepository studentRepo)
    {
        _studentRepo = studentRepo ?? throw new ArgumentNullException();
    }

    public Student GetById(int id)
    {
        Student student = _studentRepo.GetById(id);

        if (student is null) throw new NotFoundException(id, "Red", "User Not Found");

        return student;
    }
}

