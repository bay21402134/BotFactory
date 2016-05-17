using System;

namespace BotFactory.Interface
{

    public interface IReportingUnit

    {
        event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;
         
    }
}
