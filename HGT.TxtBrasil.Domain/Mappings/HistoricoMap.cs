using FluentNHibernate.Mapping;
using HGT.TxtBrasil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGT.TxtBrasil.Domain.Mappings
{
    public class HistoricoMap : ClassMap<Historico>
    {
        public HistoricoMap()
        {
            Id(x => x.Id).GeneratedBy.GuidNative();
            Map(x => x.Descricao);
            Map(x => x.DataContato);
        }
    }
}
