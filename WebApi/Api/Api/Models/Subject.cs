using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Subject
    {

        public int subject_no { get; set; }


        public string subject_name { get; set; }

        public string course_enrolled { get; set; }

    }
}
