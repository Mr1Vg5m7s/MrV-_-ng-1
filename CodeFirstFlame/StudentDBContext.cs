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

            modelBuilder.Entity<Models.Group>().HasData(
                new Models.Group { Id = 1, Name = "Group A" },
                new Models.Group { Id = 2, Name = "Group B" }
            );


            modelBuilder.Entity<Models.StudInfo>().HasData(
                new Models.StudInfo { Id = 1, Login = "ivanov", HashPassword = "ivanov123" },
                new Models.StudInfo { Id = 2, Login = "petrov", HashPassword = "petrov123" },
                new Models.StudInfo { Id = 3, Login = "sidorov", HashPassword = "sidorov123" }
            );

            modelBuilder.Entity<Models.Student>().HasData(
                new Models.Student { Id = 1, Surname = "Ivan", Name = "Ivanov", BirthDay = new DateTime(2000, 1, 1), GroupId = 1, StudInfoId = 1 },
                new Models.Student { Id = 2, Surname = "Petr", Name = "Petrov", BirthDay = new DateTime(2001, 2, 2), GroupId = 2, StudInfoId = 2 },
                new Models.Student { Id = 3, Surname = "Sidor", Name = "Sidorov", BirthDay = new DateTime(2002, 3, 3), GroupId = 1, StudInfoId = 3 }
            );

        }
    }
}
