using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Telephone.Models
{
    public partial class telephoneContext : DbContext
    {
        public telephoneContext()
        {
        }

        public telephoneContext(DbContextOptions<telephoneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Cost> Cost { get; set; }
        public virtual DbSet<Subscribe> Subscribe { get; set; }
        public virtual DbSet<Talk> Talk { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8M9BAU3;Initial Catalog=telephone;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.IdCity)
                    .HasName("PK__City__5E31E358DB595405");

                entity.Property(e => e.IdCity)
                    .HasColumnName("Id_city")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("discount_percent")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NameCity)
                    .HasColumnName("name_city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RateAm)
                    .HasColumnName("rate_am")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.RatePm)
                    .HasColumnName("rate_pm")
                    .HasMaxLength(15)
                    .IsFixedLength();
                entity.Property(p => p.IdCity).ValueGeneratedOnAdd()
                .IsRequired();
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cost1)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdTalk).HasColumnName("Id_talk");

                entity.HasOne(d => d.IdTalkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTalk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cost__Id_talk__2C3393D0");
            });

            modelBuilder.Entity<Subscribe>(entity =>
            {
                entity.HasKey(e => e.IdAbonent)
                    .HasName("PK__Subscrib__FC7E124B42073673");

                entity.Property(e => e.IdAbonent)
                    .HasColumnName("Id_abonent")
                    .ValueGeneratedNever();

                entity.Property(e => e.BankAccount)
                    .HasColumnName("bank_account")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Inpp)
                    .HasColumnName("INPP")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.NumberPhone)
                    .HasColumnName("number_phone")
                    .HasMaxLength(15);

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Talk>(entity =>
            {
                entity.HasKey(e => e.IdTalk )
                    .HasName("PK__Talk__629752E85ED897B0");

                entity.Property(e => e.IdTalk)
                    .HasColumnName("Id_talk")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ddate)
                    .HasColumnName("ddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAbonent).HasColumnName("Id_abonent");

                entity.Property(e => e.IdCity).HasColumnName("Id_city");

                entity.Property(e => e.TimeOfDate)
                    .HasColumnName("time_of_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeTalk)
                    .HasColumnName("time_talk")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdAbonentNavigation)
                    .WithMany(p => p.Talk)
                    .HasForeignKey(d => d.IdAbonent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Talk__Id_abonent__2A4B4B5E");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Talk)
                    .HasForeignKey(d => d.IdCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Talk__Id_city__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
