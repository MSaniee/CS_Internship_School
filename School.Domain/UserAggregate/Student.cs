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
        public string Name { get; set; }
    }
}
