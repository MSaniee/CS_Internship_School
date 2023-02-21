using School.Domain.UserAggregate;

namespace School.Application.Interfaces;

public interface IStudentService
{
    Student GetById(int id);
}

