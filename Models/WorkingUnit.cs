using System;
using BotFactory.Common.Tools;
using BotFactory.Interface;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    abstract public class WorkingUnit : BaseUnit, IWorkingUnit
    {

        public WorkingUnit()
        {

        }

        public Coordinates ParkingPos
        {
            get;
            set;

        }
        public Coordinates WorkingPos
        {
            get;
            set;

        }
        public bool IsWorking
        {

            get;
            set;

        }



        public WorkingUnit(Coordinates p1, Coordinates p2, bool b) : base()
        {
            ParkingPos = p1;
            WorkingPos = p2;
            IsWorking = b;

        }

        public WorkingUnit(double Temp, double Vitesse ) : base(Temp, Vitesse )
        {

        }

        public virtual async Task<bool> WorkEnds()

        {

            return true;

        }

        public virtual async Task<bool> WorkBegins()

        {
            return true;
        }

    }
}
