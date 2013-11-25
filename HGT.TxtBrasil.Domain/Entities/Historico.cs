using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGT.TxtBrasil.Domain.Entities
{
    public class Historico : IAggregateRoot<Guid>
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime DataContato { get; set; }
        public virtual string Descricao { get; set; }
    }
}
