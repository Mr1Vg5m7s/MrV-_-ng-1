using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MrV___ng_1;

public partial class HospitalDb12MrvContext : DbContext
{
    public HospitalDb12MrvContext()
    {
    }

    public HospitalDb12MrvContext(DbContextOptions<HospitalDb12MrvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Disease> Diseases { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<DoctorsExamination> DoctorsExaminations { get; set; }

    public virtual DbSet<Examination> Examinations { get; set; }

    public virtual DbSet<Inter> Inters { get; set; }

    public virtual DbSet<Professor> Professors { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=mssql-srv.step.edu;Persist Security Info=False;User ID=user12;Password=Qwert12345;Initial Catalog=HospitalDB_12_Mrv;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Departme__3214EC07C6414660");

            entity.HasIndex(e => e.Name, "UQ__Departme__737584F6A0CF123B").IsUnique();

            entity.Property(e => e.Financing).HasColumnType("money");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Disease>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Diseases__3214EC07CB74B961");

            entity.HasIndex(e => e.Name, "UQ__Diseases__737584F6AE9AD82B").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Doctors__3214EC071581A931");

            entity.Property(e => e.Salary).HasColumnType("money");
        });

        modelBuilder.Entity<DoctorsExamination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DoctorsE__3214EC07CFD9D91D");

            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Disease).WithMany(p => p.DoctorsExaminations)
                .HasForeignKey(d => d.DiseaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DoctorsEx__Disea__52593CB8");

            entity.HasOne(d => d.Doctor).WithMany(p => p.DoctorsExaminations)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DoctorsEx__Docto__534D60F1");

            entity.HasOne(d => d.Examination).WithMany(p => p.DoctorsExaminations)
                .HasForeignKey(d => d.ExaminationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DoctorsEx__Exami__5441852A");

            entity.HasOne(d => d.Ward).WithMany(p => p.DoctorsExaminations)
                .HasForeignKey(d => d.WardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DoctorsEx__WardI__5535A963");
        });

        modelBuilder.Entity<Examination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Examinat__3214EC07DABE9DCC");

            entity.HasIndex(e => e.Name, "UQ__Examinat__737584F63CC7302A").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Inter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Inters__3214EC073C13AE88");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Inters)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Inters__DoctorId__5812160E");
        });

        modelBuilder.Entity<Professor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Professo__3214EC078CA4A1E2");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Professors)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Professor__Docto__5AEE82B9");
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wards__3214EC07E39C822F");

            entity.HasIndex(e => e.Name, "UQ__Wards__737584F63671024F").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(20);

            entity.HasOne(d => d.Department).WithMany(p => p.Wards)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wards__Departmen__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
