namespace PatternsCourseWork;

public class CarBuilder : IBuilder
{
    public Chassis Chassis = new Chassis(440.1f, "titan");
    public CarBody CarBody = new CarBody(320, "aluminium", "white", "small");
    public Engine Engine = new Engine(200, "steel", 105, true, 1.2f);

    private Car car = new Car();
    
    public CarBuilder()
    {
        Reset();
    }
    
    public void Reset()
    {
        car = new Car();
    }
    
    public Engine BuildEngine()
    {
        car.Add(Engine);
        return Engine;
    }

    public CarBody BuildCarBody()
    {
        car.Add(CarBody);
        return CarBody;
    }

    public Chassis BuildChassis()
    {
        car.Add(Chassis);
        return Chassis;
    }
    
    public Car GetCar()
    {
        Car result = car;
        Reset();
        return result;
    }
}