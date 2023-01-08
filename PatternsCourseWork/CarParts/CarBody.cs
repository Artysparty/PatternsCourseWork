namespace PatternsCourseWork;

public class CarBody : IVehiclePart
{
    public float mass { get; set; }
    public string material { get; set; }
    public string color { get; set; }
    public string size { get; set; }

    public CarBody(float mass, string material, string color, string size)
    {
        this.mass = mass;
        this.material = material;
        this.color = color;
        this.size = size;
    }

    public void DoPartFunction()
    {
        Console.WriteLine("Save driver");
    }
}