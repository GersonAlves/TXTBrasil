using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGT.TxtBrasil.Domain.Entities
{
    public class Venda
    {
        public virtual Guid Id { get; set; }
        public virtual Guid VendedorId { get; set; }
        public virtual Guid ClienteId { get; set; }
    }
}
