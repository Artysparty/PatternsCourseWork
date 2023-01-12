namespace PatternsCourseWork;

public class CarBuilder : IBuilder
{
    public Chassis Chassis { get; set; }
    public CarBody CarBody { get; set; }
    public Engine Engine { get; set; }

    private Car car = new Car();
    
    public CarBuilder()
    {
        Reset();
    }
    
    public void Reset()
    {
        car = new Car();
    }
    
    public Engine BuildEngine(float mass, string material, int power, bool isTurbo, float volume)
    {
        Engine = new Engine(mass, material, power, isTurbo, volume);
        car.Add(Engine);
        return Engine;
    }

    public CarBody BuildCarBody(float mass, string material, string color, string size)
    {
        CarBody = new CarBody(mass, material, color, size);
        car.Add(CarBody);
        return CarBody;
    }

    public Chassis BuildChassis(float mass, string material)
    {
        Chassis = new Chassis(mass, material);
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