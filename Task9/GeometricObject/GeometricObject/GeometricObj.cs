// See https://aka.ms/new-console-template for more information
public abstract class GeometricObject
{
    protected double weight;
    protected string color;
    protected GeometricObject()
    {
        color = "white";
        weight = 1.0;
    }
    protected GeometricObject(double weight, string color)
    {
        this.weight = weight;
        this.color = color;
    }
    public string PColor
    {
        get { return this.color; }
        set { this.color = value; }
    }
    public double PWeight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }
    public abstract double findArea();
    public abstract double findPerimeter();
}
