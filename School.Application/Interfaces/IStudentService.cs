using School.Domain.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static School.Application.Services.StudentService;

namespace School.Application.Interfaces
{
    public interface IStudentService
    {
        event StudentEventHandler OnRegistered;
        Student GetById(int id);

        Student Register(string name);
    }
}
