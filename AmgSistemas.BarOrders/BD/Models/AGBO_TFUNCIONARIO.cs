using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders.BD.Models
{
    public class AGBO_TFUNCIONARIO
    {
        public string ID_FUNCIONARIO { get; set; }
        [ForeignKey("AGBO_TTIPO_FUNCIONARIO")]
        public string ID_TIPO_FUNCIONARIO { get; set; }
        public string COD_FUNCIONARIO { get; set; }
        public string DES_NOME { get; set; }
        public bool BOL_ATIVO { get; set; }
        public DateTime DTH_REGISTRO { get; set; }

        public AGBO_TTIPO_FUNCIONARIO AGBO_TTIPO_FUNCIONARIO { get; set; }

        public ICollection<AGBO_TFILIAL_FUNCIONARIO> AGBO_TFILIAL_FUNCIONARIO { get; set; }

        public ICollection<AGBO_TMESA_ATENDENTE> AGBO_TMESA_ATENDENTE { get; set; }
    }
}
