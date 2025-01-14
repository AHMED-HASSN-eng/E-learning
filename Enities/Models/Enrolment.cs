﻿namespace Entites.Models
{
    public class Enrolment
    {
        public string UserId {  get; set; } 
        public int CourseId { get; set; }
        public DateTime EnrollmentDate { get; set; }=DateTime.Now;
        public int Achieved { get; set; }=0;
        public virtual User? User { get; set; }
        public virtual Course? Course { get; set; }

    }
}
