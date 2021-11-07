using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TCOMANDA
    {
        public string ID_COMANDA { get; set; }
        [ForeignKey("AGBO_TMESA")]
        public string ID_MESA { get; set; }
        [ForeignKey("AGBO_TMESA_ATENDENTE")]
        public string ID_MESA_ATENDENTE { get; set; }
        [Required()]
        public string COD_COMANDA { get; set; }
        [Required()]
        public string COD_ESTADO { get; set; }
        [ForeignKey("AGBO_TFILIAL")]
        public string ID_FILIAL { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }
        public AGBO_TMESA AGBO_TMESA { get; set; }
        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public AGBO_TMESA_ATENDENTE AGBO_TMESA_ATENDENTE { get; set; }
        public ICollection<AGBO_TITEM_COMANDA> AGBO_TITEM_COMANDA { get; set; }

    }                 
}                     
                      
                      