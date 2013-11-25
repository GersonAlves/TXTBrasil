using System;

namespace Workker.Telemetria.InfraStructure.Persistence.SessionConfiguration
{
    public interface IConfigurationFactory
    {
        FluentNHibernate.Cfg.FluentConfiguration Build();
    }
}
