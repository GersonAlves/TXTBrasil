using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGT.TxtBrasil.Domain.Entities
{
    public class Cliente : IAggregateRoot<Guid>
    {
        public virtual Guid Id { get; set; }
        public virtual IList<Historico> Historicos { get; set; }
        public virtual string Nome { get; set; }

    }
}
