using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BotFactory.Common.Tools
{
    public class Vector : IVector
    {


        public Vector()
        {
            x = 0;
            y = 0;

        }

        public Vector(Double x, Double y)
        {
            this.x = x;
            this.y = y;

        }

        public double x
        {
            get;


            set;

        }

        public double y
        {
            get;
            set;

        }



        public static Vector FromCoordinates(Coordinates begin, Coordinates end)
        {

            Vector R = new Vector(end.x - begin.x, end.y - begin.y);
            return R;
        }


        public static double Length(Vector v)
        {
            double xDelta = v.x;
            double yDelta = v.y;

            return Math.Sqrt(Math.Pow(xDelta, 2) + Math.Pow(yDelta, 2));
        }


    }
}
