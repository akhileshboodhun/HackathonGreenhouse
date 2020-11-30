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
        public double fan_power { get; set; }
        public double pump_power { get; set; }
        public string led_strip_matrix { get; set; }
    }
}
