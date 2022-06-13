using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramScheduleData.Model
{
    public class Route
    {
        [Key]
        public Guid RouteId { get; set; }

        public string Name { get; set; }

        public ICollection<Stop> Stops { get; set; }

        public Route()
        {

        }

        public Route(string name, List<Stop> stops)
        {
            this.Name = name;
            this.Stops = stops;
        }
    }
}
