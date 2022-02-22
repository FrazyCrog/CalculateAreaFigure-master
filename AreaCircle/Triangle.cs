namespace AreaFigure
{
    public class Triangle: IFigure
    {
        private double sideA, sideB, sideC;


        public enum TypeTriangle
        {
            rightTriangle, // прямоугольный треугольник
            equilateralTriangle, // равносторонний треугольник
            isoscelesTriangle, // равнобедренный треугольник
            versatileTriangle, // разносторонний треугольник
            notTriangle // не треугольник
        }

        public Triangle(double _sideA, double _sideB, double _sideC)
        {
            sideA = _sideA;
            sideB = _sideB;
            sideC = _sideC;
        }

        public double Area
        {
            get
            {
                double p = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
        }


        public TypeTriangle getTypeTriangle()
        {
            if ((sideA + sideB < sideC) && (sideA + sideC < sideB) && (sideB + sideC < sideA)) // существует ли треугольник?
            {
                return TypeTriangle.notTriangle;
            }


            double c = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            if (Math.Pow(sideC, 2) == c)
            {
                return TypeTriangle.rightTriangle;  // прямоугольный треугольник
            }

            if ((sideA == sideB && sideB != sideC) || (sideA == sideC && sideC != sideB) || (sideB == sideC && sideC != sideA))
            {
                return TypeTriangle.isoscelesTriangle; // равнобедренный треугольник
            }

            if (sideA == sideB && sideB == sideC && sideA == sideC)
            {
                return TypeTriangle.equilateralTriangle; // равностороний
            }
            else
            {
                return TypeTriangle.versatileTriangle; // разносторонний треугольник
            }
        }
    }
}
