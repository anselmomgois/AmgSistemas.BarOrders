using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TFUNCIONARIO
    {
        public string ID_FUNCIONARIO { get; set; }
        public string ID_TIPO_FUNCIONARIO { get; set; }
        public string COD_FUNCIONARIO { get; set; }
        public string DES_NOME { get; set; }
        public bool BOL_ATIVO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }

        public AGBO_TTIPO_FUNCIONARIO AGBO_TTIPO_FUNCIONARIO { get; set; }
    }
}
