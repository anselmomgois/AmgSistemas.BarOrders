using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class Empresa
    {
        public string identificador {get;set;}

        public string codigo { get; set; }

        public string descricao { get; set; }
        public byte[] logo { get; set; }
    }
}
