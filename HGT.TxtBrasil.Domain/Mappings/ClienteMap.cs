using FluentNHibernate.Mapping;
using HGT.TxtBrasil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGT.TxtBrasil.Domain.Mappings
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Id(x => x.Id).GeneratedBy.GuidNative();
            Map(x => x.Nome);
            HasMany(x => x.Historicos).Cascade.All();
        }
    }
}
