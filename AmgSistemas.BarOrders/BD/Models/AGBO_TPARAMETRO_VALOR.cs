using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TPARAMETRO_VALOR
    {
        public string ID_PARAMETRO_VALOR { get; set; }
        [ForeignKey("AGBO_TFILIAL")]
        public string ID_FILIAL { get; set; }
        [ForeignKey("AGBO_TEMPRESA")]
        [Required()]
        public string ID_EMPRESA { get; set; }
        [ForeignKey("AGBO_TPARAMETROS")]
        [Required()]
        public string ID_PARAMETRO { get; set; }
        public string DES_VALOR_PARAMETRO { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }

        public AGBO_TEMPRESA AGBO_TEMPRESA { get; set; }
        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public AGBO_TPARAMETROS AGBO_TPARAMETROS { get; set; }

    }
}
