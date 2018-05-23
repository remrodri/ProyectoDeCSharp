namespace ContosoUniversity.Models
{
    //public enum Grade
    //{
    //    A, B, C, D
    //}

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //public Grade? Group { get; set; }
        public string Group { get; set; }


        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}