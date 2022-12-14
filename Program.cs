using PlanningPatterns.DesignPatterns;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Builder;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Factory;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Singleton;
using System.Runtime.CompilerServices;

//CreationalPatterns.Singleton

Singleton firstInstance = Singleton.Instance();
Singleton secondInstance = Singleton.Instance();

if (firstInstance == secondInstance)
{
    Console.WriteLine("Great, we are same instances");
}
else
{
    Console.WriteLine("Singleton failed me");
}
Console.WriteLine("-------------------------");
//CreationalPatterns.AbstractFactory - see class Client

//CreationalPatterns.Builder

var tripBuilder = new TripLaptopBuilder();
var gamingBuilder = new GamingLaptopBuilder();
var shopForYou = new BuyLaptop();

shopForYou.SetLaptopBuilder(gamingBuilder);
shopForYou.ConstructLaptop();
Laptop laptop = shopForYou.GetLaptop();
Console.WriteLine(laptop);

Console.WriteLine("-----------------------");

//CreationalPatterns.Factory

Developer dev = new PanelDeveloper("PanelDev1");
House house1 = dev.Create();

dev = new WoodDeveloper("WoodDev1");
House house2 = dev.Create();

Console.WriteLine("------------------------");

