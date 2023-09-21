//internal class Task2
//{
//    private static void Main()
//    {
//        Console.WriteLine("Введите длины сторон прямоугольника:");
//        double sideA = Convert.ToDouble(Console.ReadLine());
//        double sideB = Convert.ToDouble(Console.ReadLine());
//        Rectangle rectangle = new Rectangle(sideA, sideB);
//        Console.WriteLine($"Area = {rectangle.Area}\nPerimeter = {rectangle.Perimeter}");
//    }
//}
//public class Rectangle
//{
//    private double side1, side2;
//    private double CalculateArea()
//    {
//        if (side1 < 0 || side2 < 0) return -1;
//        return side1 * side2;
//    }
//    private double CalculatePerimeter()
//    {
//        if (side1 < 0 || side2 < 0) return -1;
//        if (side1 == 0 || side2 == 0) return side2 + side1;
//        return 2 * (side1 + side2);
//    }

//    public Rectangle(double sideA, double sideB)
//    {
//        side1 = sideA;
//        side2 = sideB;
//    }
//    public double Area { get { return CalculateArea(); } }
//    public double Perimeter { get { return CalculatePerimeter(); } }
//}
