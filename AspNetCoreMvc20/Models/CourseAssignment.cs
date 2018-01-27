namespace AspNetCoreMvc20.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CourseAssignment
    {
        [Key]
        public int InstructorId { get; set; }
        [Key]
        public int CourseId { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
