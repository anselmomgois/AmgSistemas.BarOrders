using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_PRODUTO
    {
        public string ID_PRODUTO { get; set; }
        public string ID_EMPRESA { get; set; }
        public string ID_GRUPO_PRODUTO { get; set; }
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string OBS_PRODUTO { get; set; }
        public bool BOL_ACTIVO { get; set; }
        public DateTime DTH_PRODUTO { get; set; }
        public byte[] BOL_IMAGEM { get; set; }

        public AGBO_TEMPRESA AGBO_TEMPRESA { get; set; }
        public AGBO_TGRUPO_PRODUTO AGBO_TGRUPO_PRODUTO { get; set; }
    }
}
