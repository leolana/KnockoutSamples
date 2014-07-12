using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using prjGridJson.Models.Mapping;
using SchoolServiceTest.Models.Mapping;

namespace SchoolService.Models
{
    class DatabaseContext : DbContext
    {
        //public DatabaseContext() : base()
        //{
        //   // Database.SetInitializer<PessoaContext>(new PessoaContextInitializer());
        //    Database.SetInitializer<DatabaseContext>(null);
        //}
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new CourseMap());
        }
    }
}
