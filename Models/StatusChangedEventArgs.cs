using BotFactory.Interface;
using System;

namespace BotFactory.Models
{

    public class StatusChangedEventArgs : EventArgs, IStatusChangedEventArgs
    {
          
        public string NewStatus{ get; set;}

        public  string Usine_Construction { get; set; }

       public  object RobotName { get; set; }

        public StatusChangedEventArgs(string ch)
        {
            NewStatus = ch;
        }


        public StatusChangedEventArgs()
        {
            
        }

    }
}
