using CoreWebApp1.Domain;
using CoreWebApp1.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp1.Application
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repository;
        public DbSet<Gender> Gender { get => repository.Gender; set => throw new NotImplementedException(); }
        public DbSet<Nationality> Nationality { get => repository.Nationality; set => throw new NotImplementedException(); }

        public StudentService(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public Student AddStudent(Student student)
        {
            return repository.InsertStudent(student);
        }

        public Student EditStudent(Student student)
        {
            return repository.UpdateStudent(student);
        }

        public Student GetStudent(int id)
        {
            return repository.SelectStudent(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return repository.SelectStudents();
        }

        public Student RemoveStudent(int id)
        {
            return repository.DeleteStudent(id);
        }
    }
}
