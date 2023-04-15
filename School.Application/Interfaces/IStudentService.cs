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
        Student GetById(int id);
        Student Register(string name);
        public event StudentEventHandler OnRegistered;
    }
}
