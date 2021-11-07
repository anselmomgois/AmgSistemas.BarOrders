using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TFUNCIONARIO
    {
        public string ID_FUNCIONARIO { get; set; }
        [ForeignKey("AGBO_TTIPO_FUNCIONARIO")]
        [Required()]
        public string ID_TIPO_FUNCIONARIO { get; set; }
        [Required()]
        public string COD_FUNCIONARIO { get; set; }
        [Required()]
        public string DES_NOME { get; set; }
        [Required()]
        public bool BOL_ATIVO { get; set; }
        [Required()]
        public DateTime DTH_REGISTRO { get; set; }

        public AGBO_TTIPO_FUNCIONARIO AGBO_TTIPO_FUNCIONARIO { get; set; }

        public ICollection<AGBO_TFILIAL_FUNCIONARIO> AGBO_TFILIAL_FUNCIONARIO { get; set; }

        public ICollection<AGBO_TMESA_ATENDENTE> AGBO_TMESA_ATENDENTE { get; set; }
    }
}
