﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FisrtWebApi.Models
{
    public class Usuario
    {
        [Key]
        public Int32 Id { get; set; }
        public String Nome { get; set; }
    }
}