﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGT.TxtBrasil.Domain.Entities
{
    public interface IAggregateRoot<T>
    {
        T Id { get; set; }
    }
}
