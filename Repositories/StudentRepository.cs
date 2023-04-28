using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCore.Context;
using EfCore.Interfaces;
using EfCore.Models;

namespace EfCore.Repositories
{

    public class StudentRepository : IStudentRepository
    {
        protected StudentDbContext _context;
        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
           var student = Get(id);
           _context.Students.Remove(student);
           _context.SaveChanges();
        }

        public Student Get(int id)
        {
           return _context.Students.FirstOrDefault(s=> s.Id == id);
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public void Update(Student student)
        {
           _context.Students.Update(student);
           _context.SaveChanges();
        }
    }
}