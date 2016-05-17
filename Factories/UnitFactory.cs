
using BotFactory.Common.Tools;
using BotFactory.Interface;
using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace BotFactory.Factories
{
    public class UnitFactory : ReportingFactory, IUnitFactory
    {
        public int QueueCapacity { get; private set; }
        public int StorageCapacity { get; private set; }
        private List<ITestingUnit> _storage;
        public List<ITestingUnit> Storage
        {
            get
            {
                return _storage.ToList();
            }
            set { }
        }
        static readonly object _object = new object();
        public int QueueFreeSlots
        {

            get { return QueueCapacity - _queue.Count(); }
            set { }
        }
        public int StorageFreeSlots
        {

            get { return StorageCapacity - _storage.Count(); }
            set { }
        }
        private List<IFactoryQueueElement> _queue;
        public List<IFactoryQueueElement> Queue
        {
            get
            {
                return _queue.ToList();
            }
            set { }
        }
        public TimeSpan QueueTime
        {
            get;
            set;

        }

        public UnitFactory(int a, int b)
        {
            QueueCapacity = a;
            StorageCapacity = b;
            _queue = new List<IFactoryQueueElement>();
            _storage = new List<ITestingUnit>();

        }

        public void AddWorkableUnitToQueue(Type item, string name, Coordinates coordinates1, Coordinates coordinates2)
        {

            if ((_queue.Count() < QueueCapacity) && (_storage.Count() < StorageCapacity + 1))
            {

                FactoryQueueElement obj = new FactoryQueueElement(name, item, coordinates1, coordinates2);
                _queue.Add(obj);

                object tt = Activator.CreateInstance(item);
                ITestingUnit ropotTest = Activator.CreateInstance(obj.Model, new object[] { }) as ITestingUnit;
                ropotTest.Model = name;
                ropotTest.ParkingPos = coordinates1;
                ropotTest.WorkingPos = coordinates2;
                Thread th = new Thread(() =>
              {

                  lock (_object)
                  {
                      Thread.Sleep(Convert.ToInt32(ropotTest.BuildTime) * 1000);
                      _storage.Add(ropotTest);
                      _queue.RemoveAt(_queue.Count - 1);
                      QueueTime += DateTime.Now.AddSeconds(Convert.ToInt32(ropotTest.BuildTime)) - DateTime.Now;

                      OnStatusChangedFactory(new StatusChangedEventArgs());
                  }



              });
                th.Name = "Machine a construction";
                th.Start();

            }
            else
            {
                Console.WriteLine("Impossible de construire plus de robot ");
            }

        }


    }

}
