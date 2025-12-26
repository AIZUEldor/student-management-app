using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementApp.Domain.Entities;
using StudentManagementApp.Domain.Interfaces;
using StudentManagementApp.Infrastructure.Data;

namespace StudentManagementApp.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext db;

        public StudentRepository(AppDbContext db)
        {
            db = db;
        }

        public void Add(Student st)
        {
            db.Students.Add(st);
        }

        public Student GetById(int id)
        {
            return db.Students.FirstOrDefault(s => s.id == id);
        }

        public IEnumerable<Student> GetByName(string name)
        {
            return db.Students
                      .Where(s => s.fullName.ToLower().Contains(name.ToLower()))
                      .ToList();
        }

        public IEnumerable<Student> GetAll()
        {
            return db.Students;
        }

        public bool Delete(int id)
        {
            var st = GetById(id);
            if (st == null) return false;

            db.Students.Remove(st);
            return true;
        }

        public bool Update(Student st)
        {
            var old = GetById(st.id);
            if (old == null) return false;

            old.fullName = st.fullName;
            old.age = st.age;
            return true;
        }
    }


}

