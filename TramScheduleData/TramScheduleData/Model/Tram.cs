using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramScheduleData.Model
{
    public class Tram
    {
        [Key]
        public int TramId { get; set; }
        public string Name { get; set; }
        public Route? Route { get; set; }

        public Tram()
        {

        }

        public Tram(string name)
        {
            Name = name;
        }

    }
}
