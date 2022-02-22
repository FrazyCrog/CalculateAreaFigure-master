namespace AreaFigure
{
    public class Square:IFigure
    {
        private double sideA, sideB;


        public Square(double _sideA,double _sideB)
        {
            sideA = _sideA;
            sideB = _sideB;
        }

        public double Area => sideA * sideB;
    }
}
