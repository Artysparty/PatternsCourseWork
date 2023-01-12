namespace PatternsCourseWork;

public class Car
{
    private List<IVehiclePart> _parts = new List<IVehiclePart>();

    public void Ride(Engine engine, Chassis chassis)
    {
        engine.StartEngine();
        engine.DoPartFunction();
        chassis.DoPartFunction();
        if (engine != null && chassis != null && engine.engineStarted)
        {
            Console.WriteLine("Car rides");
        }
        else
        {
            Console.WriteLine("Car can not ride without engine and chassis");
        }
    }
    
    public void Add(IVehiclePart part)
    {
        _parts.Add(part);
    }
    
    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "Product parts: " + str + "\n";
    }
}