using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_Migration.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }
    }
}
