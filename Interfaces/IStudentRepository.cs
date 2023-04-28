using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCore.Models;

namespace EfCore.Interfaces
{
    public interface IStudentRepository
    {
        public void Add(Student student);
        public void Delete(int id);
        public void Update(Student student);
        public List<Student> GetAll();
        public Student Get(int id);

    }
}