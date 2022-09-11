using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWebApp1.Domain
{
    public partial class Gender
    {
        public Gender()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Sex { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
