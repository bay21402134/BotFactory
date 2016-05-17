
using System;
using BotFactory.Interface;

namespace BotFactory.Models
{

    abstract public class ReportingUnit : BuildableUnit, IReportingUnit
    {

        public event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;
        public ReportingUnit(double Time) : base(Time) { }
        public ReportingUnit() { }

        public virtual void OnStatusChanged(StatusChangedEventArgs statuts)
        {

            if (UnitStatusChanged != null)
            {

                UnitStatusChanged(this, statuts);
                Console.WriteLine("we are " + statuts.NewStatus);
            }

        }
         
         
    }

}
