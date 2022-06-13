using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramScheduleData.Model
{
    public class Tram
    {
        [Key]
        public Guid TramId { get; set; }
        public string Name { get; set; }
        public Route _route { get; set; }

        public Tram()
        {

        }

        public Tram(string name, Route route)
        {
            Name = name;
            _route = route;
        }

    }
}
