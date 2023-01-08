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
        this._builder.BuildChassis();
    }
        
    public void BuildFullFeaturedProduct()
    {
        this._builder.BuildChassis();
        this._builder.BuildEngine();
        this._builder.BuildCarBody();
    }
}