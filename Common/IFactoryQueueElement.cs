using BotFactory.Common.Tools;
using System;


namespace BotFactory.Interface
{
    public interface IFactoryQueueElement
    {
         string Name { get; set; }
         
        Type Model
        {
            get;
            set;
        }
        Coordinates ParkingPos
        {
            get;
            set;

        }
        Coordinates WorkingPos
        {
            get;
            set;

        }

    }
}
