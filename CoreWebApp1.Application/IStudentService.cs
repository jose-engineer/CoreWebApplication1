using CoreWebApp1.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp1.Application
{
    public interface IStudentService
    {
        DbSet<Gender> Gender { get; set; }
        DbSet<Nationality> Nationality { get; set; }
        IEnumerable<Student> GetStudents();
        Student GetStudent(int id);
        Student AddStudent(Student student);
        Student EditStudent(Student student);
        Student RemoveStudent(int id);
    }
}
