namespace PatternsCourseWork;

public interface IBuilder
{
    Engine BuildEngine();
    Chassis BuildChassis();
    CarBody BuildCarBody();
}