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
        public DbSet<Route> Routes { get; set; }
        public DbSet<Stop> Stops { get; set; }

        public DbSet<Tram> Trams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=TramSchedule;Integrated Security=True");
        }

    }
}
