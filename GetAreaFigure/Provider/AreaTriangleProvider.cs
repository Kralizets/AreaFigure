using System;
using System.Linq;

namespace AreaFigure
{
    public class AreaTriangleProvider : BaseAreaFigureProvider
    {
        public override double? GetArea(double[] parametrs)
        {
            //Sides can't be less or more then 3
            //Side can't be negative or zero
            //Max side can't be more then two others
            //Throw null reference will can lie into try-catch
            if (parametrs.Length != 3 || parametrs.Any(side => side <= 0) || IsNotTriangle(parametrs.OrderByDescending(side => side).ToArray()))
            {
                return null;
            }

            double halfPerimetr = GetHalfPerimetr(parametrs);
            double areaTriangle = GetAreaTriangle(parametrs, halfPerimetr);

            return areaTriangle;
        }

        public bool? IsRightTriangle(double[] sides)
        {
            //Sides can't be less or more then 3
            //Side can't be negative or zero
            //Max side can't be more then two others
            //Throw null reference will can lie into try-catch
            if (sides.Length != 3 || sides.Any(side => side <= 0) || IsNotTriangle(sides.OrderByDescending(side => side).ToArray()))
            {
                return null;
            }

            double[] sortedSides = sides.OrderByDescending(side => side).ToArray();

            if (Math.Pow(sortedSides[0], 2) == (Math.Pow(sortedSides[1], 2) + Math.Pow(sortedSides[2], 2)))
            {
                return true;
            }

            return false;
        }

        private bool IsNotTriangle(double[] sortedSides)
        {
            if (sortedSides[0] >= (sortedSides[1] + sortedSides[2]))
            {
                return true;
            }

            return false;
        }

        private double GetHalfPerimetr(double[] sides)
        {
            return 0.5 * sides.Sum();
        }

        private double GetAreaTriangle(double[] sides, double halfPerimetr)
        {
            return Math.Pow(halfPerimetr * (halfPerimetr - sides[0]) * (halfPerimetr - sides[1]) * (halfPerimetr - sides[2]), 0.5);
        }
    }
}