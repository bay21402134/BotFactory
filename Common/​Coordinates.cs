using BotFactory.Interface;
using System;

namespace BotFactory.Common.Tools
{
    public class Coordinates : System.Object, ICoordinates
    {


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

        public Coordinates(Double x, double y)
        {
            this.x = x;
            this.y = y;

        }
 
        public bool Equals(Coordinates p)
        {
            // If parameter is null return false:
            if ((object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (x == p.x) && (y == p.y);
        }



    }
}
