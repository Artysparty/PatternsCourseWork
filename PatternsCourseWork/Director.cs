namespace PatternsCourseWork;

public class Director
{
    private IBuilder _builder;
        
    public IBuilder Builder
    {
        set { _builder = value; } 
    }
    
    public void BuildMinimalViableProduct()
    {
        this._builder.BuildChassis(200, "steel");
    }
        
    public void BuildFullFeaturedProduct()
    {
        this._builder.BuildChassis(200, "steel");
        this._builder.BuildEngine(200, "steel", 200, true, 2);
        this._builder.BuildCarBody(200, "steel", "red", "small");
    }
}