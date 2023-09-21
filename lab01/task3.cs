using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class task3
{
    static void throwing(Byte a)
    {
        if (a != 3 && a != 4 && a != 5) { throw new ArgumentException(); }
    }

    private static int Main()
    {
        Console.WriteLine("Введите количество вершин фигуры:");
        Byte DotsCount = Convert.ToByte(Console.ReadLine());
        try
        {
            throwing(DotsCount);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Мы такое не умеем т.т");
            return -1;
        }
        Console.WriteLine("Введите координаты точки А:");
        int Ax = Convert.ToInt32(Console.ReadLine());
        int Ay = Convert.ToInt32(Console.ReadLine());
        Point A = new Point(Ax, Ay);
        Console.WriteLine("Введите координаты точки B:");
        int Bx = Convert.ToInt32(Console.ReadLine());
        int By = Convert.ToInt32(Console.ReadLine());
        Point B = new Point(Bx, By);
        Console.WriteLine("Введите координаты точки C:");
        int Cx = Convert.ToInt32(Console.ReadLine());
        int Cy = Convert.ToInt32(Console.ReadLine());
        Point C = new Point(Cx, Cy);
        Figure figure;
        if (DotsCount == 3) { figure = new Figure(A, B, C); }
        else
        {
            Console.WriteLine("Введите координаты точки D:");
            int Dx = Convert.ToInt32(Console.ReadLine());
            int Dy = Convert.ToInt32(Console.ReadLine());
            Point D = new Point(Dx, Dy);
            if (DotsCount == 4) { figure = new Figure(A, B, C, D); }
            else
            {
                Console.WriteLine("Введите координаты точки D:");
                int Ex = Convert.ToInt32(Console.ReadLine());
                int Ey = Convert.ToInt32(Console.ReadLine());
                Point E = new Point(Ex, Ey);
                figure = new Figure(A, B, C, D, E);
            }
        }
        Console.WriteLine($"Периметр {figure.Name}a = {figure.PerimeterCalculator()}");
        return 0;
    }
}
public class Point
{
    private int x, y;
    public int X { get { return this.x; } }
    public int Y { get { return this.y; } }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Figure
{
    private Point a, b, c, d, e;
    private string name;
    public string Name
    { get { return name; } }
    public Figure(Point A, Point B, Point C)
    {
        a = A;
        b = B;
        c = C;
        name = "треугольник";
    }
    public Figure(Point A, Point B, Point C, Point D) : this(A, B, C)
    {
        d = D;
        name = "четырёхугольник";
    }
    public Figure(Point A, Point B, Point C, Point D, Point E) : this(A, B, C, D)
    {
        e = E;
        name = "пятиугольник";
    }
    public double LengthSide(Point A, Point B)
    {
        return Math.Pow(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2), 0.5);
    }
    public double PerimeterCalculator()
    {
        if (name == "треугольник") { return this.LengthSide(a, b) + this.LengthSide(b, c) + this.LengthSide(a, c); }
        if (name == "четырёхугольник") { return this.LengthSide(a, b) + this.LengthSide(b, c) + this.LengthSide(c, d) + this.LengthSide(d, a); }
        else { return this.LengthSide(a, b) + this.LengthSide(b, c) + this.LengthSide(c, d) + this.LengthSide(d, e) + this.LengthSide(e, a); }
    }
}
