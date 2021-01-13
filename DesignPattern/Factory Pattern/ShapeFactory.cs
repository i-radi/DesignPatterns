namespace DesignPattern.Factory_Pattern
{
    public class ShapeFactory
    {
        public Shape getShape(string type)
        {
            return type switch
            {
                "R" => new Rectangle(4, 5),
                "S" => new Square(5),
                "C" => new Circle(3),
                _ => null
            };
        }
    }
}