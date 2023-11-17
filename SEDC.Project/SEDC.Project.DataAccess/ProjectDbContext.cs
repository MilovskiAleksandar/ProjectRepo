using Microsoft.EntityFrameworkCore;
using SEDC.Project.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Project.DataAccess
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .Property(x => x.Username)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(x => x.FirstName)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(x => x.LastName)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(x => x.Password)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(x => x.Email)
                .IsRequired();

            //TASK
            modelBuilder.Entity<Tasks>()
                .Property(x => x.Name)
                .IsRequired();

            modelBuilder.Entity<Tasks>()
                .Property(x => x.Priority)
                .IsRequired();
            modelBuilder.Entity<Tasks>()
                .Property(x => x.Description)
                .HasMaxLength(100);

            modelBuilder.Entity<Tasks>()
                .HasOne(x => x.User)
                .WithMany(x => x.TasksList)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Tasks>()
                .Property(x => x.ShortBreak)
                .IsRequired();

            modelBuilder.Entity<Tasks>()
                .Property(x => x.LongBreak)
                .IsRequired();

            modelBuilder.Entity<Tasks>()
                .Property(x => x.WorkTime)
                .IsRequired();


            //Reminders

            modelBuilder.Entity<Reminder>()
                .Property(x => x.Name)
                .IsRequired();

            modelBuilder.Entity<Reminder>()
                .Property(x => x.CreatedOn)
                .IsRequired();

            modelBuilder.Entity<Reminder>()
                .HasOne(x => x.User)
                .WithMany(x => x.Reminders)
                .HasForeignKey(x => x.UserId);

                














            modelBuilder.Entity<User>()
                .HasData(
                    new User { Id = 1, FirstName = "Aleksandar", LastName = "Milovski", Username = "acomilovski", Password = "aco123", Email = "Aco@hotmail.com"}
                );

            modelBuilder.Entity<Tasks>()
                .HasData(

                    new Tasks { Id = 1, Name = "Do the coding", Description = "YOU MUST CODE", Priority = 1, UserId = 1, LongBreak = 1, ShortBreak = 2, WorkTime = 10 }

                );

            modelBuilder.Entity<Reminder>()
                .HasData(
                    new Reminder { Id = 1, CreatedOn = DateTime.Now, Name = "Do the homework", UserId = 1}

                );

        }
    }
}
