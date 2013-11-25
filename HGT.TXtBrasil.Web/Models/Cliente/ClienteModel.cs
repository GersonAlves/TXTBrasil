using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.TXtBrasil.Web.Models.Cliente
{
    public class ClienteModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj {get;set;}
        public string Endereco {get;set;}
        public string Uf {get; set;}
        public string Telefone {get; set;}
        public string Site {get; set;}
        public string Email {get; set;} 

        public IList<HistoricoModel> HistoricosView { get; set; }

    }
}