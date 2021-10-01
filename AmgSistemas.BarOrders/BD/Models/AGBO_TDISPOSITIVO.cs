using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TDISPOSITIVO
    {
        public string ID_DISPOSITIVO { get; set; }
        [ForeignKey("AGBO_TMESA_ATENDENTE")]
        [Required()]
        public string ID_MESA_ATENDENTE { get; set; }
        [Required()]
        public string COD_DISPOSITIVO { get; set; }
        [Required()]
        public DateTime DTH_DISPOSITIVO { get; set; }
        public AGBO_TMESA_ATENDENTE AGBO_TMESA_ATENDENTE { get; set; }
    }
}
