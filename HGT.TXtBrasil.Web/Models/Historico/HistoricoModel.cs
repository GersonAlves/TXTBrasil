using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.TXtBrasil.Web.Models
{
    public class HistoricoModel
    {
        public Guid Id { get; set; }
        public DateTime DataContato { get; set; }
        public string Descricao { get; set; }
    }
}