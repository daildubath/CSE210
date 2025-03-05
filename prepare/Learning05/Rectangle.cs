public class Rectange : Shape
{
    private double _side1 = 4; 
    private double _side2 = 3; 
    

    public Rectange(string color) : base(color)
    {

    }


    public override double GetArea()
    {
        return _side1 * _side2;
    }




}