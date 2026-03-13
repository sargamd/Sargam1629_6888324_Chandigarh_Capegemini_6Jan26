using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HospitalDBFirstMVC.Models;

public partial class HospitalMvcdbContext : DbContext
{
    public HospitalMvcdbContext()
    {
    }

    public HospitalMvcdbContext(DbContextOptions<HospitalMvcdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-HP1513\\SQLEXPRESS01;Database=hospitalMVCdb;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__appointm__8ECDFCC2882EFD82");

            entity.ToTable("appointments");

            entity.Property(e => e.AppointmentId).ValueGeneratedNever();
            entity.Property(e => e.Remarks).HasMaxLength(500);

            entity.HasOne(d => d.Doctor).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK__appointme__Docto__619B8048");

            entity.HasOne(d => d.Patient).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__appointme__Remar__60A75C0F");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__doctors__2DC00EBF64E36C92");

            entity.ToTable("doctors");

            entity.Property(e => e.DoctorId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Specialization)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__patients__970EC366FEE8596D");

            entity.ToTable("patients");

            entity.Property(e => e.PatientId).ValueGeneratedNever();
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
