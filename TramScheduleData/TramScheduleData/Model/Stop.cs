using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramScheduleData.Model
{
    public class Stop
    {

        [Key]
        public Guid StopId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        public Stop(string name, string details)
        {
            Name = name;
            Details = details;
        }

        public Stop()
        {

        }

    }
}
