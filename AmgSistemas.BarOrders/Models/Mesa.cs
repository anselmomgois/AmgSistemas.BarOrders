using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class Mesa
    {
        public string identificador { get; set; }
        public string codigo { get; set; }
        public string codigoEstado { get; set; }
        public bool ativo { get; set; }
    }
}
