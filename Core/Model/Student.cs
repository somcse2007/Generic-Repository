using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    [Table("tblStudent")]
    public class Student : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StudentNo { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Class Class { get; set; }

    }

}

