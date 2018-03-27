using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Wonderbox.Exam.Models;

namespace Wonderbox.Exam
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Person> Persons { get; set; }
        public SchoolContext():base("Server=.\\sqlexpress;Database=Wonderbox; Trusted_Connection=True; MultipleActiveResultSets=True;")
        {
            Database.SetInitializer<SchoolContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}