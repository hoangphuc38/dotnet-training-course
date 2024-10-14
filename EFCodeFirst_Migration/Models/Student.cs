using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_Migration.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string FullName { get; set; } = string.Empty;

        public DateTime EnrollmentDate { get; set; } = DateTime.Now;

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
