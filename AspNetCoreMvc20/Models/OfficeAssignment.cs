using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMvc20.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorId { get; set; }

        [DataType("varchar(40)")]
        [StringLength(40)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}