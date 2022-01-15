using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Abstract;
using MVC_1.Models.Abstract.Schedule;
using MVC_1.Models.Rating;
using MVC_1.Models.ViewModel;
using MVC_1.Models.Deadline;
using MVC_1.Models.Account;

namespace MVC_1.Models.Database
{
    public class IBTSMContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<DeadLine> DeadLines { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<IdRating> Ratings { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<HighMath> HighMathScores { get; set; }
        public DbSet<OTK> OTKScores { get; set; }
        public DbSet<Philosophy> PhilosophyScores { get; set; }
        public DbSet<KompBaza> KompBazaScores { get; set; }
        public DbSet<Metrologia> MetrologiaScores { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<NameLink> NameLinks { get; set; }
        public DbSet<Timer> Time { get; set; }

        public IBTSMContext(DbContextOptions<IBTSMContext> options)
                   : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string mainAdminRoleName = "mainAdmin";
            string adminRoleName = "admin";
            string studentRoleName = "student";
            string guestRoleName = "guest";

            string mainAdminEmail = "mainAdmin@gmail.com";
            string mainAdminPassword = "777";
            string adminEmail = "admin@gmail.com";
            string adminPassword = "777";

            Role mainAdminRole = new Role { Id = 1, Name = mainAdminRoleName };
            Role adminRole = new Role { Id = 2, Name = adminRoleName };
            Role studentRole = new Role { Id = 3, Name = studentRoleName };
            Role guestRole = new Role { Id = 4, Name = guestRoleName };

            User mainAdmin = new User { Id = 1, Email = mainAdminEmail, Password = mainAdminPassword, RoleId = mainAdminRole.Id };
            User admin = new User { Id = 2, Email = adminEmail, Password = adminPassword, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { mainAdminRole, adminRole, studentRole, guestRole });
            modelBuilder.Entity<User>().HasData(new User[] { mainAdmin, admin });

            base.OnModelCreating(modelBuilder);
        }

    }
}
