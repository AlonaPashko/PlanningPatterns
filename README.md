# PlanningPatterns

Studying patterns of design and composition. 

Project has two folders: Engine and Interfaces. 

Engine has the class Component - superclass for AirCompressor, ElectricStarter, PneumaticStarter, HydraulicStarter, 
Batery and HydraulicPump classes. Also this folder has an IgnitionResult enum, that takes two values: Success and Failure.

Interfaces has the IComponentInterface, also has the IStarterInteface that implement an IComponentInterface. Also exist 
IHydrawlicStarter, IPneumaticStarter and IElectricStarter interfaces, which implements the IStarter interface and also
implemented in the classes assigned to them.

Also this project has an EngineDiagram for this arhitecture.

As well was created some another classes, for example ElectricBus or Car classes, but was deleted because that wasn`t need at
this actual moment.