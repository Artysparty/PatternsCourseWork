namespace PatternsCourseWork;

public class Engine : IVehiclePart
{
    public float mass { get; set; }
    public string material { get; set; }
    public int power { get; set; }
    public bool isTurbo { get; set; }
    public float volume { get; set; }

    public Engine(float mass, string material, int power, bool isTurbo, float volume)
    {
        this.material = material;
        this.mass = mass;
        this.power = power;
        this.isTurbo = isTurbo;
        this.volume = volume;
    }

    public void DoPartFunction()
    {
        Console.WriteLine("Spin the wheels");
    }
}