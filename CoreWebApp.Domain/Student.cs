using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApp1.Domain
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string SocialNumber { get; set; }
        public int? GenderId { get; set; }
        public int? NationalityId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual Nationality Nationality { get; set; }
    }
}
