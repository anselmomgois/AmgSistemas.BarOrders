using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TPARAMETROS
    {
        public string ID_PARAMETRO { get; set; }
        [Required()]
        public string COD_PARAMETRO { get; set; }
        [Required()]
        public string DES_PARAMETRO { get; set; }
        [Required()]
        public string COD_TIPO_PARAMETRO { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }
        [Required()]
        public bool BOL_ACTIVO { get; set; }

        public ICollection<AGBO_TPARAMETRO_VALOR> AGBO_TPARAMETRO_VALOR { get; set; }
    }
}
