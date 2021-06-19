using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TPARAMETROS
    {
        public string ID_PARAMETRO { get; set; }
        public string COD_PARAMETRO { get; set; }
        public string DES_PARAMETRO { get; set; }
        public string COD_TIPO_PARAMETRO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }
        public bool BOL_ACTIVO { get; set; }
    }
}
