namespace PatternsCourseWork;

public class CarBuilder : IBuilder
{
    private Car car = new Car();
    
    public Chassis Chassis = new Chassis(440.1f, "titan");
    public CarBody CarBody = new CarBody(320, "aluminium", "white", "small");
    public Engine Engine = new Engine(200, "steel", 105, true, 1.2f);

    public CarBuilder()
    {
        Reset();
    }
    
    public void Reset()
    {
        car = new Car();
    }
    
    public void BuildEngine()
    {
        car.Add(Engine);
    }

    public void BuildCarBody()
    {
        car.Add(CarBody);
    }

    public void BuildChassis()
    {
        car.Add(Chassis);
    }
    
    public Car GetCar()
    {
        Car result = car;
        Reset();
        return result;
    }
}