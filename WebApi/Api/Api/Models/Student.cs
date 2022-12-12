using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Api.Models
{
    public class Student
    {

        public int student_roll_no { get; set; }

        public string student_name { get; set; }
        
        public string dob { get; set; }
        public int subject_no { get; set; }
    }
}
