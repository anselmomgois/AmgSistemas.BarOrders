using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TFILIAL_FUNCIONARIO
    {
        public string ID_FILIAL_FUNCIONARIO { get; set; }
        public string ID_FILIAL { get; set; }
        public string ID_FUNCIONARIO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }

        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public AGBO_TFUNCIONARIO AGBO_TFUNCIONARIO { get; set; }

    }
}

