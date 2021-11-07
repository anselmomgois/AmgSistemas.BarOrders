using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    [Table("AGBO_TMESA")]
    public class AGBO_TMESA
    {
        public string ID_MESA { get; set; }
        [ForeignKey("AGBO_TFILIAL")]
        [Required()]
        public string ID_FILIAL { get; set; }
        [Required()]
        public string COD_MESA { get; set; }
        [Required()]
        public string COD_ESTADO { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }
        [Required()]
        public bool BOL_ATIVO { get; set; }

        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public ICollection<AGBO_TCOMANDA> AGBO_TCOMANDA { get; set; }
        public ICollection<AGBO_TMESA_ATENDENTE> AGBO_TMESA_ATENDENTE { get; set; }
    }
}
