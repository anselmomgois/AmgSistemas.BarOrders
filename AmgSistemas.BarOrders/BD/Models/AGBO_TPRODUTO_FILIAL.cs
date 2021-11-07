using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TPRODUTO_FILIAL
    {

        public string ID_PRODUTO_FILIAL { get; set; }
        [ForeignKey("AGBO_PRODUTO")]
        [Required()]
        public string ID_PRODUTO { get; set; }
        [ForeignKey("AGBO_TFILIAL")]
        [Required()]
        public string ID_FILIAL { get; set; }
        [Required()]
        public decimal NUM_VALOR { get; set; }
        [Required()]
        public decimal NUM_QUANTIDADE { get; set; }

        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public AGBO_TPRODUTO AGBO_TPRODUTO { get; set; }

        public ICollection<AGBO_TITEM_COMANDA> AGBO_TITEM_COMANDA { get; set; }
    }
}
