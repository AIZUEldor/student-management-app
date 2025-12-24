using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Domain.Entities
{
    public class Student
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public int age { get; set; }
    }
}
