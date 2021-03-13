using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TGRUPO_PRODUTO
    {

        public string ID_GRUPO_PRODUTO { get; set; }
        public string ID_GRUPO_PRODUTO_PAI { get; set; }
        public string ID_EMPRESA { get; set; }
        public string COD_GRUPO_PRODUTO { get; set; }
        public string DES_GRUPO_PRODUTO { get; set; }

        public AGBO_TEMPRESA AGBO_TEMPRESA { get; set; }
        public ICollection<AGBO_TGRUPO_PRODUTO> AGBO_TGRUPO_PRODUTO1 { get; set; }
        public AGBO_TGRUPO_PRODUTO AGBO_TGRUPO_PRODUTO2 { get; set; }
    }
}
