using System;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Interface;


namespace BotFactory.Models
{
    abstract public class BaseUnit : ReportingUnit, IBaseUnit
    {
        public string Name { get; set; }
        public double Vitesse { get; set; }
        public double Time { get; set; }
        public Coordinates CurrentPos { get; set; }

        public BaseUnit() { }
          
        public BaseUnit(double Time, double Vitesse) : base(Time)
        {
            this.Vitesse = Vitesse;
            this.CurrentPos = new Coordinates(0, 0);
        }

        public async Task<bool> Move(Coordinates DebPos, Coordinates FinalPos)
        {
            if (DebPos.Equals(FinalPos))
            {
                return false;
            }
            else
            {
                Vector v = new Vector();
                v = Vector.FromCoordinates(DebPos, FinalPos);
                Console.WriteLine("$le Robot se deplace: ");

                int a = Convert.ToInt32(Vector.Length(v) / Vitesse);
                await Task.Delay(a * 1000);

                return true;

            }

        }
 
         
           

         

    }
}
