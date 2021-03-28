using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TPRODUTO_FILIAL
    {

        public string ID_PRODUTO_FILIAL { get; set; }
        public string ID_PRODUTO { get; set; }
        public string ID_FILIAL { get; set; }
        public decimal NUM_VALOR { get; set; }
        public decimal NUM_QUANTIDADE { get; set; }

        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public AGBO_PRODUTO AGBO_PRODUTO { get; set; }
    }
}
