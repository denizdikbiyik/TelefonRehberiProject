using System;
using System.Collections.Generic;
using System.Text;
using TelefonRehberi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TelefonRehberi.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TelefonRehberi.Models.Department> Department { get; set; }
        public DbSet<TelefonRehberi.Models.Worker> Worker { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Worker>()
        .HasOne(b => b.Department)
        .WithMany(a => a.Workers)
        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Worker>()
      .HasOne(b => b.WorkerManager)
      .WithMany(a => a.Workers)
      .OnDelete(DeleteBehavior.Restrict);
        }
    }
}