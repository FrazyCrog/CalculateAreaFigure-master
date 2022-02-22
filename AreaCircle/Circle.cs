namespace AreaFigure
{
    public class Circle
    {
        private double radius;

        public Circle(double _radius)
        {
            if(_radius < 0)
            {
                _radius = 0;
            }
            radius = _radius;
        }

        public double Area => Math.PI * Math.Pow(radius, 2);
    }
}
