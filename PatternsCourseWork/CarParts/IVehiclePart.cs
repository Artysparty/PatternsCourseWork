namespace PatternsCourseWork;

public interface IVehiclePart
{
    public float mass { get; set; }
    public string material { get; set; }
    
    
    void DoPartFunction() {}
}