using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolService.Models;

namespace prjGridJson.Models.Mapping
{
    //public class CourseMap : EntityTypeConfiguration<Course>
    //{
    //    public CourseMap()
    //    {
    //        // Primary Key
    //        this.HasKey(c => c.CourseID)
    //            .Property(c => c.CourseID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); ;
    //        // Propercies
    //        this.Property(c => c.CourseName).IsRequired().HasMaxLength(50);
    //        this.Property(c => c.CompletionDate).IsRequired();
    //        // cable & Column Mappings
    //        this.ToTable("CURSO");
    //        this.Property(c => c.CourseID).HasColumnName("CURSOID");
    //        this.Property(c => c.CourseName).HasColumnName("CURSONOME");
    //        this.Property(c => c.CompletionDate).HasColumnName("DATACONCLUSAO");
    //    }
    //}
}