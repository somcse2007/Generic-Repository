using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    [Table("tblClass")]
    public class Class : BaseEntity
    {
        [Key]
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
    }
}
