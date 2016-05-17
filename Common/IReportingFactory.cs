using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
   public interface IReportingFactory
    {
        event EventHandler FactoryProgress;
        List<IFactoryQueueElement> Queue { get; set; }
        int QueueCapacity { get; }
        int QueueFreeSlots { get; }
        TimeSpan QueueTime { get; }
        List<ITestingUnit> Storage { get; }
        int StorageCapacity { get; }
        int StorageFreeSlots { get; }
        void AddWorkableUnitToQueue(Type item, string name, Coordinates coordinates1, Coordinates coordinates2);
    }
}
