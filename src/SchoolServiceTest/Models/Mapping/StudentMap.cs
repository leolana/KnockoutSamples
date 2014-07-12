using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SchoolService;

namespace prjGridJson.Models.Mapping
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            // Primary Key
            this.HasKey(s => s.StudentId)
                .Property(s => s.StudentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            // Properties
            this.Property(s => s.StudentName)
                .IsRequired()
                .HasMaxLength(50);
            this.Property(s => s.DateOfBirth).IsRequired();
            this.Property(s => s.Phone).HasMaxLength(15);
            this.Property(s => s.Address).HasMaxLength(50);
            this.Property(s => s.CEP).HasMaxLength(10);
            // Table & Column Mappings
            this.ToTable("PESSOA");
            this.Property(s => s.StudentId).HasColumnName("PESSOAID");
            this.Property(s => s.StudentName).HasColumnName("NOME");
            this.Property(s => s.DateOfBirth).HasColumnName("DATANASC");
            this.Property(s => s.Phone).HasColumnName("TELEFONE");
            this.Property(s => s.Address).HasColumnName("ENDERECO");
            this.Property(s => s.CEP).HasColumnName("CEP");
            //this.HasMany(p => p.Cursos).WithOptional(c => c.Pessoa).Map(x => x.MapKey("PESSOAID"));
            this.HasMany(s => s.Courses).WithMany(s => s.Students)
                .Map(
                    x =>
                    {
                        x.MapLeftKey("PESSOAID");
                        x.MapRightKey("CURSOID");
                        x.ToTable("PESSOA_CURSO");
                    }
                );

        }
    }
}