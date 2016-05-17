using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
   public interface IBaseUnit
    {

        String Name
        {
            get;
            set;
        }

        double Vitesse
        {
            get;
            set;
        }

        Coordinates  CurrentPos
        {
            get;
            set;
        }
 
        Task<bool> Move(Coordinates CurentPos, Coordinates FinalPos);
    

    }
}
