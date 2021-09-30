using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TITEM_COMANDA
    {
      public string  ID_ITEM_COMANDA { get; set; }
        [ForeignKey("AGBO_TCOMANDA")]
        public string ID_COMANDA { get; set; }
        [ForeignKey("AGBO_TPRODUTO_FILIAL")]
        public string ID_PRODUTO_FILIAL { get; set; }
        public decimal NUM_QUANTIDADE { get; set; }
        public DateTime  DTH_REGISTRO { get; set; }
        public AGBO_TCOMANDA AGBO_TCOMANDA { get; set; }
        public AGBO_TPRODUTO_FILIAL AGBO_TPRODUTO_FILIAL { get; set; }

    }
}
