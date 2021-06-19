using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class Parametro
    {
        public string identificador { get; set; }
        public string codigo { get; set; }
        public string descricao { get; set; }
        public Enumeradores.TipoParametro tipoParametro { get; set; }
        public string valor { get; set; }
    }
}
