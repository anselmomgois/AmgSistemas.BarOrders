using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TEMPRESA
    {
        public string ID_EMPRESA { get; set; }
        public string COD_EMPRESA { get; set; }
        public string DES_EMPRESA { get; set; }
        public bool BOL_ACTIVO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }
    }
}
