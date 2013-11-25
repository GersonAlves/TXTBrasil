using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workker.Telemetria.InfraStructure.Persistence.SessionManagement;

namespace Workker.Telemetria.InfraStructure.Persistence.UnitOfWorkComponent
{
    public class UnitOfWorkFactory
    {
        public static IUnitOfWork GetDefault()
        {
            return new UnitOfWork(new SessionBuilder());
        }
    }
}
