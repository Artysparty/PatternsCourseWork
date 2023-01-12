namespace PatternsCourseWork;

public interface IBuilder
{
    Engine BuildEngine(float mass, string material, int power, bool isTurbo, float volume);
    Chassis BuildChassis(float mass, string material);
    CarBody BuildCarBody(float mass, string material, string color, string size);
}