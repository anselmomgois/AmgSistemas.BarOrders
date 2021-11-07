using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TFILIAL_FUNCIONARIO
    {
        public string ID_FILIAL_FUNCIONARIO { get; set; }
        [ForeignKey("AGBO_TFILIAL")]
        [Required()]
        public string ID_FILIAL { get; set; }
        [ForeignKey("AGBO_TFUNCIONARIO")]
        [Required()]
        public string ID_FUNCIONARIO { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }

        public AGBO_TFILIAL AGBO_TFILIAL { get; set; }
        public AGBO_TFUNCIONARIO AGBO_TFUNCIONARIO { get; set; }

    }
}

