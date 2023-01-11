namespace PatternsCourseWork.Facade;

public class CarFacade
{
    public CarBuilder builder = new CarBuilder();

    public void Ride()
    {
        Engine engine = builder.BuildEngine();
        Chassis chassis = builder.BuildChassis();
        Car car = builder.GetCar();
        car.Ride(engine, chassis);
    }
}