using PatternsCourseWork;
using PatternsCourseWork.Facade;

var director = new Director();
var builder = new CarBuilder();
director.Builder = builder;

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetCar().ListParts());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetCar().ListParts());


//without director
Console.WriteLine("Custom product:");
builder.BuildChassis(200, "titan");
builder.BuildEngine(400, "steel", 400, true, 3.2f);
Console.Write(builder.GetCar().ListParts());

CarFacade facade = new CarFacade();
facade.Ride();

//Without facade
Car car = new Car();

Engine engine = new Engine(200, "steel", 214, false, 2.3f);
Chassis chassis = new Chassis(243, "steel and plastic");
CarBody carBody = new CarBody(400, "aluminium", "red", "big");

car.Add(engine);
car.Add(chassis);
car.Add(carBody);

engine.StartEngine();
car.Ride(engine, chassis);

