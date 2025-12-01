using CodeFirstFlame.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFlame
{
    internal class StudentDBContext : DbContext
    {
        public StudentDBContext() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=mssql-srv.step.edu;Persist Security Info=False;User ID=user12;Password=Qwert12345;Initial Catalog=Student_DB_MrV;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Models.Student>().ToTable("Flame");
           // modelBuilder.Entity<Student>().Property("GetCode").HasField("code");
           // modelBuilder.Entity<Models.Student>().Property(s => s.Name).IsRequired();

            //modelBuilder.Entity<Student>().HasAlternateKey(s => s.Surname).HasName("codik");
            modelBuilder.Entity<Models.Student>().ToTable(t => t.HasCheckConstraint("CK_Students_Name", "Name <>''"));
            modelBuilder.Entity<Models.Student>().HasData(
             new Models.Student { Id = 1, Name = "Ivan", Surname = "Ivanov", BirthDay = new DateTime(2000, 1, 1) },
             new Models.Student { Id = 2, Name = "Petr", Surname = "Petrov", BirthDay = new DateTime(2001, 2, 2) },
             new Models.Student { Id = 3, Name = "Sidor", Surname = "Sidorov", BirthDay = new DateTime(2002, 3, 3) }
);
        }
    }
}
