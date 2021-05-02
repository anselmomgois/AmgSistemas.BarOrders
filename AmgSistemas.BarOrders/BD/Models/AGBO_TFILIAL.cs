using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TFILIAL
    {
        public string ID_FILIAL { get; set; }
        public string ID_EMPRESA { get; set; }
        public string COD_FILIAL { get; set; }
        public string DES_FILIAL { get; set; }
        public bool BOL_ACTIVO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }
        public bool BOL_TRABALHA_POR_MESA { get; set; }
        public bool BOL_SOLICITAR_TELEFONE { get; set; }
        public AGBO_TEMPRESA AGBO_TEMPRESA { get; set; }
    }
}
