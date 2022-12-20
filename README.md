# PlanningPatterns

Studying patterns of design and composition. 

Project has folders: 

- Engine, 
- Animal, 
- ClassAssociation, 
- AggregationExample,
- CompositionExample,
- Interfaces. 

Engine has the class Component - superclass for AirCompressor, ElectricStarter, PneumaticStarter, HydraulicStarter, 
Batery and HydraulicPump classes. Also this folder has an IgnitionResult enum, that takes two values: Success and Failure.

Animals has the class Animal - superclass for Eagle and Panter. Class Eagle implements an IFlying interface and class Panter 
implements an IRunning interface.

The ClassAssociation folder has Student and Teacher classes that are in association with each other, an example description of 
which is given in the class ClientCode of the same folder.

The AggregationExample folder has Department and Teacher classes. ClientCode class (in the same folder) presents a connection
between Teachers and Department, where the Teachers as a part of the Department.

The CompositionExample folder includes University class, the part of which is a Department class from AggregationExample folder.
ClientCode here presents an example of composition.

Interfaces has the IComponentInterface, also has the IStarterInteface that implement an IComponentInterface. Also exist 
IHydrawlicStarter, IPneumaticStarter and IElectricStarter interfaces, which implements the IStarter interface and also
implemented in the classes assigned to them.
Also this folder has IFlying and IRunning interfaces.

Also this project has an EngineDiagram for the Engine folder and AnimalDiagram for the Animal folder.

As well was created some another classes, for example ElectricBus or Car classes, but was deleted because that wasn`t need at
this actual moment.

