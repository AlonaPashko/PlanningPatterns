using PlanningPatterns.DesignPatterns;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Builder;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Factory;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Prototype;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Singleton;
using PlanningPatterns.DesignPatterns.StructuralPatterns.Decorator;
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

//CreationalPatterns.Prototype

IFigure figure = new Rectangle(30, 40);
IFigure clonedFigure = figure.Clone();

figure.GetInfo();
clonedFigure.GetInfo();

figure = new Circle(30);
clonedFigure = figure.Clone();

figure.GetInfo();
clonedFigure.GetInfo();

Console.WriteLine("----------------------");

//StructuralPatterns.Decorator

ICake cake = new SimpleCake();
ICake cake1 = new WithWhippedCream(cake);
ICake cake2 = new WithSprinkles(cake1);

Console.WriteLine(cake2.Ingredients());
Console.WriteLine(cake2.Price().ToString());

ICake cake4 = new WithSprinkles(new WithWhippedCream(new SimpleCake()));
Console.WriteLine(cake4.Ingredients());
Console.WriteLine(cake4.Price().ToString());

