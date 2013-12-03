using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGT.TxtBrasil.Domain.Entities
{
    public class Vendedor
    {
        public virtual Guid Id { get; set; }
        public virtual IList<Venda> Vendas { get; set; }
        public virtual string Nome { get; set; }
    }
}
