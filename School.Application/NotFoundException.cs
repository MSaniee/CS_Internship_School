using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application
{
    public class NotFoundException : Exception
    {
        public int StudentId { get; set; }
        public string Status { get; set; }

        public NotFoundException(int studentId, string status, string message) : base(message)
        {
            StudentId = studentId;
            Status = status;
        }
    }
}
