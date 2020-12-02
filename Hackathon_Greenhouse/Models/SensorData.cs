using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_Greenhouse.Models
{
    public class SensorData
    {
        [Key]
        public int id { get; set; }
        public double temp { get; set; }
        public double humidity { get; set; }
        public bool fan { get; set; }
        public bool pump { get; set; }
        public bool servo { get; set; }
        public bool is_moist { get; set; }

        public bool high_light_intensity { get; set; }
        public bool isLightOn { get; set; }
        public string date_time { get; set; }
    }
}
