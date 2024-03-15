namespace AbstractFactory
{

    public interface IShape
    {
        void Draw();
    }
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw basic Circle"); ;
        }
    }
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw basic Square"); ;
        }
    }
    class RoundedCircle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rounded Circle"); ;
        }
    }
    class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rounded Square"); ;
        }
    }

    public enum Shape{
        Circle,
        Square
    }

    // abstract factory
    public abstract class ShapeFactory
    {
        public abstract IShape Create(Shape shape);
    }

    // 2 concrete factory
    public class BasicShapeFactory : ShapeFactory
    {
        public override IShape Create(Shape shape) => shape switch
        {
            Shape.Circle => new Circle(),
            Shape.Square => new Square(),
            _=>throw new ArgumentOutOfRangeException(nameof(shape),shape,null),
        };
       
    }

    public class RoundedShapeFActory : ShapeFactory
    {
        public override IShape Create(Shape shape) => shape switch
        {

            Shape.Circle => new RoundedCircle(),
            Shape.Square => new RoundedSquare(),
            _ => throw new ArgumentOutOfRangeException(nameof(shape), shape, null),

        };
        
    }


    internal class Program
    {
        public static ShapeFactory GetFactory(bool rounded)
        {
            if(rounded)
            {
                return new RoundedShapeFActory();
            }
            return new BasicShapeFactory();
        }
        static void Main(string[] args)
        {
            var basic=GetFactory(false).Create(Shape.Circle);
            basic.Draw();

            var rounded=GetFactory(true).Create(Shape.Square);
            rounded.Draw();
        }
    }
}
