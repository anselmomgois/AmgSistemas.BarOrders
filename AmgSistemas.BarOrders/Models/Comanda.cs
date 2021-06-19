using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class Comanda
    {
        public string identificador { get; set; }
        public string codigo { get; set; }
        public Enumeradores.EstadoComanda estado { get; set; }
    }
}
