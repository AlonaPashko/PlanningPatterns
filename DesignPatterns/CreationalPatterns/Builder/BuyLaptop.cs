using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPatterns.DesignPatterns.CreationalPatterns.Builder
{
    internal class BuyLaptop
    {
        private LaptopBuilder laptopBuilder;

        public void SetLaptopBuilder(LaptopBuilder IBuilder)
        {
            this.laptopBuilder = IBuilder;
        }
        public Laptop GetLaptop()
        {
            return laptopBuilder.GetMyLaptop();
        }
        public void ConstructLaptop()
        {
            laptopBuilder.CreateNewLaptop();
            laptopBuilder.SetMonitorResolution();
            laptopBuilder.SetProcessor();
            laptopBuilder.SetMemory();
            laptopBuilder.SetHDD();
            laptopBuilder.SetBattery();
        }
    }
}
