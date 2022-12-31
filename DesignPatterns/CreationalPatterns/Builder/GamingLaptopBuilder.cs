using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Builder;

namespace PlanningPatterns.DesignPatterns.CreationalPatterns.Builder
{
    internal class GamingLaptopBuilder : LaptopBuilder
    {
        public override void SetBattery()
        {
            Laptop.Battery = "6 Ibs";
        }

        public override void SetHDD()
        {
            Laptop.Hdd = "500 Gb";
        }

        public override void SetMemory()
        {
            Laptop.Memory = "6144 Mb";
        }

        public override void SetMonitorResolution()
        {
            Laptop.MonitorResolution = "1900*1200";
        }

        public override void SetProcessor()
        {
            Laptop.Processor = "Core 2 Duo, 3.2Ghz";
        }

    }
}
