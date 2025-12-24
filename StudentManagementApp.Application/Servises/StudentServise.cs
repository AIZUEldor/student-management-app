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
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public void Add(int id, string name, int age)
        {
            var st = new Student()
            {
                id = id,
                fullName = name,
                age = age
            };

            _repo.Add(st);
        }

        public Student GetById(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<Student> GetByName(string name)
        {
            return _repo.GetByName(name);
        }

        public IEnumerable<Student> GetAll()
        {
            return _repo.GetAll();
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public bool Update(int id, string name, int age)
        {
            return _repo.Update(new Student
            {
                id = id,
                fullName = name,
                age = age
            });
        }
    }
}
