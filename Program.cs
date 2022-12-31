using PlanningPatterns.DesignPatterns;
using PlanningPatterns.DesignPatterns.CreationalPatterns.Singleton;

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

