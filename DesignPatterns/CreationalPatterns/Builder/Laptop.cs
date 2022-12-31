using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.CreationalPatterns.Builder
{
    internal class Laptop
    {
        public static string MonitorResolution { get; set; }
        public static string Processor { get; set; }
        public static string Memory { get; set; }
        public static string Hdd { get; set; }
        public static string Battery { get; set; }

        public override string ToString()
        {
            return "Laptop: " + MonitorResolution + " " + Processor + " " + Memory
                 + " " + Hdd + " " + Battery;
        }
    }
}
