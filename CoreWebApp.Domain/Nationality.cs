using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApp1.Domain
{
    public partial class Nationality
    {
        public Nationality()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
