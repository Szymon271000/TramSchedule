using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramScheduleData.Model
{
    public class Route
    {
        [Key]
        public int RouteId { get; set; }

        public string Name { get; set; }

        public ICollection<Stop> Stops { get; set; }

        public Route()
        {

        }

        public Route(string name)
        {
            this.Name = name;
            Stops = new List<Stop>();
        }
    }
}
