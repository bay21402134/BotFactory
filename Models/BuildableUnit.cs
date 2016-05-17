using BotFactory.Interface;
using System;


namespace BotFactory.Models
{
    abstract public class BuildableUnit : IBuildableUnit
    {
        public double BuildTime { get; set; }
        public String Model { get; set; }

        public BuildableUnit()
        {
            BuildTime = 5000;
        }

        public BuildableUnit(double Temps)
        {
            BuildTime = Temps;

        }

    }
}
