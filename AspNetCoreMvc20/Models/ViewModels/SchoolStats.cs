namespace AspNetCoreMvc20.Models.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SchoolStats
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}

