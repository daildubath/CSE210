public class Square : Shape
{
    private double _side = 5; 

    public Square(string color) : base(color)
    {

    }


    public override double GetArea()
    {
        return _side * _side;
    }




}