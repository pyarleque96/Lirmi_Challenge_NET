using Lirmi.Challenge.Data.Context.Core;
using Lirmi.Challenge.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lirmi.Challenge.Data.Context
{
    public partial class LirmiContext : BaseContext
    {
        public LirmiContext()
        {
        }

        public LirmiContext(DbContextOptions<LirmiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grade", "Main");

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Type).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Grade)
                    .HasForeignKey(d => d.SchoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grade_School");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("School", "Main");

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ShortName).HasMaxLength(250);

                entity.Property(e => e.TypeDescription).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject", "Main");

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ShortName).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("timestamp without time zone")
                    .HasDefaultValueSql("timezone('utc'::text, now())");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Subject)
                    .HasForeignKey(d => d.GradeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subject_Grade");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
