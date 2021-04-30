using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TMESA
    {
        public string ID_MESA { get; set; }
        public string ID_FILIAL { get; set; }
        public string COD_MESA { get; set; }
        public string COD_ESTADO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }
        public bool BOL_ATIVO { get; set; }

        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
    }
}
