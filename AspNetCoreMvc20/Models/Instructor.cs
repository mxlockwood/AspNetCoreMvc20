using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreMvc20.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [DataType("varchar(40)")]
        [StringLength(40)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [DataType("varchar(40)")]
        [StringLength(40)]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        [Display(Name = "Courses")]
        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        [Display(Name = "Office Location")]
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}