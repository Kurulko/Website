using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Abstract;
using MVC_1.Models.Abstract.Schedule;
using MVC_1.Models.Rating;

namespace MVC_1.Models.Database
{
    public class IBTSMContext : DbContext
    {
        public DbSet<IdRating> Ratings { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<HighMath> HighMathScores { get; set; }
        public DbSet<OTK> OTKScores { get; set; }
        public DbSet<Philosophy> PhilosophyScores { get; set; }
        public DbSet<KompBaza> KompBazaScores { get; set; }
        public DbSet<Metrologia> MetrologiaScores { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Place> Links { get; set; }
        public DbSet<Timer> Time { get; set; }

        public IBTSMContext(DbContextOptions<IBTSMContext> options)
                   : base(options)
        {
            Database.EnsureCreated();
        }
        
    }
}
