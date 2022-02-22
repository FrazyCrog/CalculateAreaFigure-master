using AreaFigure;


Console.WriteLine("Введите радиус круга");
Circle circle = new Circle(int.Parse(Console.ReadLine()));
Console.WriteLine("Площадь круга = " + circle.Area);

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Введите стороны треугольника");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
Triangle triangle = new Triangle(a, b, c);

if(triangle.getTypeTriangle() == Triangle.typeTriangle.notTriangle)
{
    Console.WriteLine("Это не треугольник!");
}
else
{
    Console.WriteLine("Площадь треугольника = " + triangle.Area);
}

