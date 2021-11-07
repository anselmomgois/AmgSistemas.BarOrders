using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TPRODUTO
    {
        public string ID_PRODUTO { get; set; }
        [ForeignKey("AGBO_TEMPRESA")]
        [Required()]
        public string ID_EMPRESA { get; set; }
        [ForeignKey("AGBO_TGRUPO_PRODUTO")]
        [Required()]
        public string ID_GRUPO_PRODUTO { get; set; }
        [Required()]
        public string COD_PRODUTO { get; set; }
        [Required()]
        public string DES_PRODUTO { get; set; }
        public string OBS_PRODUTO { get; set; }
        [Required()]
        public bool BOL_ACTIVO { get; set; }
        [Required()]
        public DateTime DTH_PRODUTO { get; set; }
        public byte[] BOL_IMAGEM { get; set; }

        public AGBO_TEMPRESA AGBO_TEMPRESA { get; set; }
        public AGBO_TGRUPO_PRODUTO AGBO_TGRUPO_PRODUTO { get; set; }
        public ICollection<AGBO_TPRODUTO_FILIAL> AGBO_TPRODUTO_FILIAL { get; set; }
    }
}
