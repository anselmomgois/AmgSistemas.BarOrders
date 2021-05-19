using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class Pedido
    {
        public string identificadorComanda { get; set; }
        public string identificadorMesa { get; set; }
        public string identificadorMesaAtendente { get; set; }
        public string codigoComanda { get; set; }
        public List<ItemPedido> itensPedido { get; set; }
    }
}
