using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Wonderbox.Exam
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }    
        [Column("FirstName")]
        public string FirstMidName { get; set; }         
    }
}