using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class ItemPedido
    {
        public string identificadorItemComanda {get;set;}
        public string identificadorProdutoFilial { get; set; }
        public decimal quantidade { get; set; }

    }
}
