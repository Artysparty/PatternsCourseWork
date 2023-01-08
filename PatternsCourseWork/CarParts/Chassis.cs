namespace PatternsCourseWork;

public class Chassis : IVehiclePart
{
    public float mass { get; set; }
    public string material { get; set; }

    public Chassis(float mass, string material)
    {
        this.mass = mass;
        this.material = material;
    }

    public void DoPartFunction()
    {
        Console.WriteLine("Ride");
    }
}