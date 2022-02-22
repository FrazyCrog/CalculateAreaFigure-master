using AreaFigure;


Console.WriteLine("Введите радиус круга");
Circle circle = new Circle(int.Parse(Console.ReadLine()));
Console.WriteLine("Площадь круга = " + circle.Area);

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Введите стороны треугольника");
int a = Convert.ToInt32()
Console.ReadLine();
int b = int.Parse(Console.Read());
Console.ReadLine();
int c = int.Parse(Console.Read());


Triangle triangle = new Triangle(a, b, c);

if(triangle.getTypeTriangle() == Triangle.TypeTriangle.notTriangle)
{
    Console.WriteLine("Это не треугольник!");
}
else
{
    Console.WriteLine("Площадь треугольника = " + triangle.Area);
}

