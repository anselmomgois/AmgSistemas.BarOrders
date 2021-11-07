using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TGRUPO_PRODUTO
    {

        public string ID_GRUPO_PRODUTO { get; set; }
        [ForeignKey("AGBO_TGRUPO_PRODUTO1")]
        public string ID_GRUPO_PRODUTO_PAI { get; set; }
        [ForeignKey("AGBO_TEMPRESA")]
        [Required()]
        public string ID_EMPRESA { get; set; }
        [Required()]
        public string COD_GRUPO_PRODUTO { get; set; }
        [Required()]
        public string DES_GRUPO_PRODUTO { get; set; }

        public AGBO_TEMPRESA AGBO_TEMPRESA { get; set; }
        public AGBO_TGRUPO_PRODUTO AGBO_TGRUPO_PRODUTO1 { get; set; }

        public ICollection<AGBO_TPRODUTO> AGBO_TPRODUTO { get; set; }
        public ICollection<AGBO_TGRUPO_PRODUTO> AGBO_TGRUPO_PRODUTO2 { get; set; }
    }
}
