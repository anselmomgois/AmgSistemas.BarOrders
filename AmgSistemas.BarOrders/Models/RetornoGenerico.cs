using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class RetornoGenerico
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public object retorno { get; set; }
    }
}
