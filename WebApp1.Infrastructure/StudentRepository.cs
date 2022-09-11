using CoreWebApp1.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp1.Infrastructure
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext context;

        public DbSet<Gender> Gender { get => context.Genders; set => throw new NotImplementedException(); }
        public DbSet<Nationality> Nationality { get => context.Nationalities; set => throw new NotImplementedException(); }

        public StudentRepository(SchoolDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> SelectStudents()
        {
            return context.Students;
        }

        public Student SelectStudent(int id)
        {
            return context.Students.Find(id);
        }

        public Student InsertStudent(Student student)
        {
            try
            {
                var added = context.Students.Add(student);
                context.SaveChanges();

                return added.Entity;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public Student UpdateStudent(Student student)
        {
            var stu = context.Students.Find(student.StudentId);
            stu.FirstName = student.FirstName;
            stu.LastName = student.LastName;
            stu.SocialNumber = student.SocialNumber;
            stu.NationalityId = student.NationalityId;
            stu.GenderId = student.GenderId;

            context.SaveChanges();

            return stu;            
        }

        public Student DeleteStudent(int id)
        {
            var stu = context.Students.Find(id);
            var deleted = context.Remove(stu);
            context.SaveChanges();
            return deleted.Entity;
        }
    }
}
