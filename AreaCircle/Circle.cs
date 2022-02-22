namespace AreaFigure
{
    public class Circle
    {
        private double radius;

        public Circle(double _radius)
        {
            radius = _radius;
        }

        public double Area => Math.PI * Math.Pow(radius, 2);
    }
}
