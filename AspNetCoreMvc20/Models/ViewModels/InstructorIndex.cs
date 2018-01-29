using System.Collections.Generic;

namespace AspNetCoreMvc20.Models.ViewModels
{
    public class InstructorIndex
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}
