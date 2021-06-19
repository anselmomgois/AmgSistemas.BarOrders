using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TCOMANDA
    {
        public string ID_COMANDA { get; set; }
        public string ID_MESA { get; set; }
        public string ID_MESA_ATENDENTE { get; set; }
        public string COD_COMANDA { get; set; }
        public string COD_ESTADO { get; set; }
        public string ID_FILIAL { get; set; }
        public DateTime DTH_REGISTRO { get; set; }
        public AGBO_TMESA AGBO_TMESA { get; set; }
        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public AGBO_TMESA_ATENDENTE AGBO_TMESA_ATENDENTE { get; set; }

    }                 
}                     
                      
                      