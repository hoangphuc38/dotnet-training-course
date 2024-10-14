using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_Migration.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Title { get; set; } = string.Empty;

        [Index]
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
