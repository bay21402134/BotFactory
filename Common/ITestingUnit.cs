using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Interface;

namespace BotFactory.Interface
{

    public interface ITestingUnit : IBaseUnit, IBuildableUnit, IReportingUnit, IWorkingUnit
    {
         
    }
}
