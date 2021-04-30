using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.Models
{
    public class ProdutoFilial:Produto
    {
        public decimal valor { get; set; }
        public decimal quantidade { get; set; }
        
    }
}
