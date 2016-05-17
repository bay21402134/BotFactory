using BotFactory.Interface;
using BotFactory.Models;
using System;
 

namespace BotFactory.Factories
{
    public class ReportingFactory  
    {

        public event EventHandler FactoryProgress;

        public virtual void OnStatusChangedFactory( EventArgs statuts)
        {

            if (FactoryProgress != null)
            {

                FactoryProgress(this, statuts);


            }

        }

    }
}
