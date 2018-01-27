namespace AspNetCoreMvc20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [Column("FirstName", Order = 1)]
        [DataType("varchar(40)")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "First name cannot be longer than 40 characters.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [Column(Order = 2)]
        [DataType("varchar(40)")]
        [StringLength(40, MinimumLength = 1, ErrorMessage = "Last name cannot be longer than 40 characters.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string LastName { get; set; }

        [Display(Name = "Enrollment Date")]
        [Column(Order = 3)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        [DataType("varchar(80)")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}