using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BaluNatanApp
{
    public partial class recruitmentDBContext : DbContext
    {
        public recruitmentDBContext()
        {
        }

        public recruitmentDBContext(DbContextOptions<recruitmentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountNumber> AccountNumbers { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Partner> Partners { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("workstation id=recruitmentDB.mssql.somee.com;packet size=4096;user id=nbalu_SQLLogin_1;pwd=xbr1ucetxc;data source=recruitmentDB.mssql.somee.com;persist security info=False;initial catalog=recruitmentDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountNumber>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountNumbers)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nip).HasColumnName("NIP");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.Nip);

                entity.Property(e => e.Nip).HasColumnName("NIP");

                entity.Property(e => e.HasVirtualAccounts)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Krs)
                    .HasMaxLength(10)
                    .HasColumnName("KRS")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Pesel)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RegistrationDenialBasis)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RegistrationDenialDate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RegistrationLegalDate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Regon)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemovalBasis)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemovalDate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ResidenceAddress)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RestorationBasis)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RestorationDate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.StatusVat)
                    .HasMaxLength(10)
                    .HasColumnName("StatusVAT")
                    .IsFixedLength();

                entity.Property(e => e.WorkingAddress)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Nip).HasColumnName("NIP");

                entity.Property(e => e.Partners)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
