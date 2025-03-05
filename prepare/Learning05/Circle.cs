using System.Net.NetworkInformation;

public class Circle : Shape
{
    private double _radius = 3.6; 
    

    public Circle(string color) : base(color)
    {

    }


    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }




}