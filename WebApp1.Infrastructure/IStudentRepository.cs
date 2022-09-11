using CoreWebApp1.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp1.Infrastructure
{
    public interface IStudentRepository
    {
        DbSet<Gender> Gender { get; set; }
        DbSet<Nationality> Nationality { get; set; }
        IEnumerable<Student> SelectStudents();
        Student SelectStudent(int id);
        Student InsertStudent(Student student);
        Student UpdateStudent(Student student);
        Student DeleteStudent(int id);
    }
}
