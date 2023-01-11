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
builder.BuildChassis();
builder.BuildEngine();
Console.Write(builder.GetCar().ListParts());

CarFacade facade = new CarFacade();
facade.Ride();
