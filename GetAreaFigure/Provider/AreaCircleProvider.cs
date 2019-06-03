using System;

namespace AreaFigure
{
    public class AreaCircleProvider : BaseAreaFigureProvider
    {
        //Raduis can't be less or more then 3
        //Raduis can't be negative or zero
        public override double? GetArea(double[] parametrs)
        {
            if (parametrs.Length != 1 || parametrs[0] <= 0)
            {
                return null;
            }

            return GetAreaCircle(parametrs[0]);
        }

        private double GetAreaCircle(double raduis)
        {
            return Math.PI * Math.Pow(raduis, 2);
        }
    }
}