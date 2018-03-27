using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Wonderbox.Exam.Models
{    
    public class Student:Person
    {
        public DateTime EnrollmentDate { get; set; }
    }
}