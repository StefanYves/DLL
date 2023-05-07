namespace ShapeDLL
{
    // Interfața pentru calcularea ariei
    public interface IShape
    {
        double CalculateArea();
    }

    

    // Clasa Figura geometrică de bază
    public class Shape : IShape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    //Clasa Triangle
    public class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double CalculateArea()
        {
            // Calculam aria folosing formula lui Heron
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
    }

        // Clasa Cerc
        public class Circle : Shape
    {
        public double Radius { get; set; }
        

        public Circle(double radius)
        {
            Radius = radius;
           
        }


        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    // Clasa Dreptunghi
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // Clasa Pătrat
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }
    }
}