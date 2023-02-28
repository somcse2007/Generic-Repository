using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    [Table("tblCourse")]
    public class Course : BaseEntity
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public List<Class> Classes { get; set; }
    }
}
