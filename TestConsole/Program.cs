using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Models;
using BotFactory.Common.Tools;
using BotFactory.Interface;
using BotFactory.Factories;

namespace BotFactory.Models
{
    class Program
    {


        static void Main(string[] args)
        {
            Coordinates p1 = new Coordinates(7, 6);
            Coordinates p2 = new Coordinates(20, 20);

            UnitFactory ff = new UnitFactory(3, 4);

            Console.WriteLine("QueueFree" + ff.QueueFreeSlots);
            Console.WriteLine("StorageFree" + ff.StorageFreeSlots);


            ff.AddWorkableUnitToQueue( typeof(T_800), "bayrem", p1, p2);
            ff.AddWorkableUnitToQueue( typeof(R2D2), "bayrem1", p1, p2);
            ff.AddWorkableUnitToQueue( typeof(HAL), "bayrem2", p1, p2);
            ff.AddWorkableUnitToQueue( typeof(Wall_E), "bayrem3", p1, p2);

            Wall_E ss = new Wall_E();
            ss.OnStatusChanged(new StatusChangedEventArgs("My new wall_E"));
            System.Threading.Thread.Sleep(90000);
            Console.WriteLine("QueueFree" + ff.QueueFreeSlots);
            Console.WriteLine("StorageFree" + ff.StorageFreeSlots);


            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
