using BotFactory.Common.Tools;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface IWorkingUnit
    {

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
        bool IsWorking
        {

            get;
            set;
        }
        Task<bool> WorkEnds();
        Task<bool> WorkBegins();

    }
}
