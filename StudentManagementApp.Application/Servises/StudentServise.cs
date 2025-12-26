using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementApp.Domain.Entities;
using StudentManagementApp.Domain.Interfaces;
using StudentManagementApp.Domain.Models;

namespace StudentManagementApp.Application.Servises
{
    public class StudentService
    {
        private readonly IStudentRepository repo;

        public StudentService(IStudentRepository repo)
        {
            repo = repo;
        }

        public void Add(int id, string name, int age)
        {
            var st = new Student()
            {
                id = id,
                fullName = name,
                age = age
            };

            repo.Add(st);
        }

        public Student GetById(int id)
        {
            return repo.GetById(id);
        }

        public IEnumerable<Student> GetByName(string name)
        {
            return repo.GetByName(name);
        }

        public IEnumerable<Student> GetAll()
        {
            return repo.GetAll();
        }

        public bool Delete(int id)
        {
            return repo.Delete(id);
        }

        public bool Update(int id, string name, int age)
        {
            return repo.Update(new Student
            {
                id = id,
                fullName = name,
                age = age
            });
        }
    }
}
