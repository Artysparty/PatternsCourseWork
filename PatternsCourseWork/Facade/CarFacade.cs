namespace PatternsCourseWork.Facade;

public class CarFacade
{
    public CarBuilder builder = new CarBuilder();

    public void Ride()
    {
        Engine engine = builder.BuildEngine(200, "steel", 200, true, 2);
        Chassis chassis = builder.BuildChassis(200, "steel");
        Car car = builder.GetCar();
        car.Ride(engine, chassis);
    }
}