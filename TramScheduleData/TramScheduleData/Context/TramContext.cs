using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TramScheduleData.Model;

namespace TramScheduleData.Context
{
    public class TramContext: DbContext
    {
        private readonly bool _isTest;

        public DbSet<Route> Routes { get; set; }
        public DbSet<Stop> Stops { get; set; }

        public DbSet<Tram> Trams { get; set; }

        public TramContext()
        {

        }

        public TramContext(DbContextOptions<TramContext> dbContextOptions, bool isTest = false) : base(dbContextOptions)
        {
            _isTest = isTest;
    }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!_isTest)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=TramSchedule;Integrated Security=True");
            }
        }

    }
}
