using BotFactory.Common.Tools;
using BotFactory.Interface;
using BotFactory.Models;
using System;


namespace BotFactory.Factories
{
    public class FactoryQueueElement : IFactoryQueueElement
    {
        public string Name { get; set; }
        event EventHandler<IStatusChangedEventArgs> test;
        public Type Model
        {
            get;
            set;
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

        public FactoryQueueElement()
        {

        }

        public FactoryQueueElement(string nom, Type model, Coordinates p1, Coordinates p2)
        {
            Name = nom;
            Model = model;
            ParkingPos = p1;
            WorkingPos = p2;
            test += FactoryQueueElement_test;
        }

        private void FactoryQueueElement_test(object sender, IStatusChangedEventArgs e)
        {
            new StatusChangedEventArgs("statuts") { NewStatus = "sldk" };
        }
    }
}
